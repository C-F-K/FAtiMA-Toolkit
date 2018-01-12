﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using CommeillFaut.DTOs;
using Conditions;
using Conditions.DTOs;
using SerializationUtilities;
using WellFormedNames;
using GAIPS.Rage;
using KnowledgeBase;
using WellFormedNames.Collections;



namespace CommeillFaut
{
       [Serializable]
    public sealed class CommeillFautAsset  : LoadableAsset<CommeillFautAsset>, ICustomSerialization
    {

        public KB m_kB;
        public List<SocialExchange> m_SocialExchanges { get; set; }

        /// <summary>
        /// The Comme ill Faut constructor
        /// </summary>

        public KB LinkedEA
        {
            get { return m_kB; }
        }

        public CommeillFautAsset()
        {
            m_kB = null;
            m_SocialExchanges = new List<SocialExchange>();
          
        }

        /// <summary>
        /// Binds a KB to this Comme ill Faut Asset instance. Without a KB instance binded to this asset, 
        /// comme ill faut evaluations will not work properly.
        /// InvalidateCachedCIF() is automatically called by this method.
        /// </summary>
        /// <param name="kb">The Knowledge Base to be binded to this asset.</param>
        public void RegisterKnowledgeBase(KB kB)
        {
            if (m_kB != null)
            {
                //Unregist bindings
                UnbindToRegistry(m_kB);
                m_kB = null;
            }

            m_kB = kB;
            BindToRegistry(kB);
         
        
        }

        #region Dynamic Properties

        public void BindToRegistry(IDynamicPropertiesRegistry registry)
        {
            //       registry.RegistDynamicProperty(CIF_DYNAMIC_PROPERTY_NAME, CIFPropertyCalculator);
       
            registry.RegistDynamicProperty(VOLITION_PROPERTY_TEMPLATE, VolitionPropertyCalculator);
        }

       

        private static readonly Name VOLITION_PROPERTY_TEMPLATE = (Name)"Volition";

        public IEnumerable<DynamicPropertyResult> VolitionPropertyCalculator(IQueryContext context, Name socialMoveName, Name initiator, Name Target)
        {
            Dictionary<SubstitutionSet, Name> ret = new Dictionary<SubstitutionSet, Name>();

            var stringVolition = "";
            var possibleSE = new List<SocialExchange>();
            bool SEConstraint = false;


            if (context.Perspective != Name.SELF_SYMBOL)
                yield break;

            if (initiator == Target)
                yield break;



            List<Name> possibleSEs = new List<Name>();

            if (socialMoveName.IsVariable)
            {
                foreach (var s in context.AskPossibleProperties(socialMoveName))
                    possibleSEs.Add(s.Item1.Value);

                foreach (var se in this.m_SocialExchanges)
                    possibleSEs.Add(se.Name);
            }
            else possibleSEs.Add(socialMoveName);


            List<Name> possibleInitiators = new List<Name>();

            if (initiator.IsVariable)
            {
                foreach (var s in context.AskPossibleProperties(initiator))
                    possibleInitiators.Add(s.Item1.Value);

                if (!possibleInitiators.Contains(context.Queryable.Perspective))
                    possibleInitiators.Add(context.Queryable.Perspective);
            }
            else possibleInitiators.Add(initiator);


            List<Name> possibleTargets = new List<Name>();

            if (Target.IsVariable)
            {
                foreach (var s in context.AskPossibleProperties(Target))
                    possibleTargets.Add(s.Item1.Value);
            }
            else possibleTargets.Add(Target);



            foreach (var seName in possibleSEs)
            {

                if (!m_SocialExchanges.Exists(x => x.Name == seName))
                    continue;

                foreach (var init in possibleInitiators)

                    foreach (var targ in possibleTargets)
                    {
                        if (init == targ) continue;


                        var volValue = CalculateSocialMoveVolition(seName, init, targ);


                        if (volValue != -1)
                        {

                            var subSet = new SubstitutionSet();


                            stringVolition = CalculateStyle(volValue);

                            if (socialMoveName.IsVariable)
                            {
                                var sub = new Substitution(socialMoveName, new ComplexValue(seName, 1));
                                subSet.AddSubstitution(sub);
                            }

                            if (initiator.IsVariable)
                            {
                                var sub = new Substitution(initiator, new ComplexValue(init, 1));
                                subSet.AddSubstitution(sub);
                            }

                            if (Target.IsVariable)
                            {
                                var sub = new Substitution(Target, new ComplexValue(targ, 1));
                                subSet.AddSubstitution(sub);
                            }

                            if (context.Constraints.Count() > 0)

                                foreach (var c in context.Constraints)
                                {
                                    if (c.Conflicts(subSet))
                                        continue;

                                    c.AddSubstitutions(subSet);

                                    yield return new DynamicPropertyResult(new ComplexValue(Name.BuildName(stringVolition)), c);
                                }

                            else yield return new DynamicPropertyResult(new ComplexValue(Name.BuildName(stringVolition)), subSet);

                        }

                    }

            }
        }

      public void UnbindToRegistry(IDynamicPropertiesRegistry registry)
        {
            registry.UnregistDynamicProperty((Name)"Volition");
        }

        #endregion

        private void ValidateEALink()
        {
            if (m_kB == null)
                throw new InvalidOperationException($"Cannot execute operation as an instance of {nameof(CommeillFautAsset)} was not registed in this asset.");
        }





        public Guid AddExchange(SocialExchangeDTO newExchange)
        {
            var newSocialExchange = new SocialExchange(newExchange);

            
      
            if(m_SocialExchanges != null)
              {

              // m_SocialExchanges = new List<SocialExchange>();
            if(m_SocialExchanges.Find(x => x.Name == newExchange.Name) != null)
                    UpdateSocialExchange(newExchange);

                   else m_SocialExchanges.Add(newSocialExchange);

               
            }
            return new Guid();
        }


     
        public void UpdateSocialExchange(SocialExchangeDTO reactionToEdit, SocialExchangeDTO newReaction)
        {
            m_SocialExchanges.Remove(new SocialExchange(reactionToEdit));

            var newId = this.AddExchange(newReaction);

           
            
         
        }

        public double Floor(float value)
        {
            var toRet = Convert.ToDouble(value);
            // Console.WriteLine("Round method calculation for: " + x.ToString() + " the value : " + toRet);
            toRet = toRet / 10;
            toRet = Math.Round(toRet, 0);
            toRet = toRet * 10;
         //   Console.WriteLine("Round method calculation for: " + x.ToString() + " rounded value " + sub.Value.ToString() + " result : " + toRet);

            return toRet;
        }


        public string CalculateStyle(float value)
        {
        
            if(value > 0.6)
                return value <= 1 ? "Positive" : "VeryPositive";

            if (value < 0.4)
                return value >= 0 ? "Negative" : "VeryNegative";
           
            return "Neutral";
        }




        public void UpdateSocialExchange(SocialExchangeDTO newReaction)
        {
          

            m_SocialExchanges.Remove(m_SocialExchanges.Find(x => x.Name == newReaction.Name));

            m_SocialExchanges.Add(new SocialExchange(newReaction));
        }


        public void RemoveSocialExchange(SocialExchange torem)
        {
           
                m_SocialExchanges.Remove(torem);
           
        }

        public SocialExchange GetSocialMove(Name socialExchangeName)
        {
          return  m_SocialExchanges.Find(x => x.Name == socialExchangeName);
        }


        public float CalculateSocialMoveVolition(Name seName, Name initiator, Name target)
        {
         return   m_SocialExchanges.Find(x => x.Name == seName).VolitionValue(initiator, target, this.m_kB);
        }


        #region Custom Serialization

        public void GetObjectData(ISerializationData dataHolder, ISerializationContext context)
        {
            
               dataHolder.SetValue("SocialExchanges", m_SocialExchanges.ToArray());

        }

        public void SetObjectData(ISerializationData dataHolder, ISerializationContext context)
        {
            
            m_SocialExchanges = new List<SocialExchange>(dataHolder.GetValue<SocialExchange[]>("SocialExchanges"));
        }


        #endregion

       

        /// <summary>
        /// Load a Comme ill Faut Asset definition from a DTO object.
        /// </summary>
        /// <remarks>
        /// Use this to procedurally configure the asset.
        /// </remarks>
        /// <param name="dto">
        /// The DTO containing the data to load
        /// </param>
        public void LoadFromDTO(CommeillFautDTO dto)
        {
            m_SocialExchanges.Clear();


            if (dto._SocialExchangesDtos != null)
            {
                foreach (var c in dto._SocialExchangesDtos)
                {
                 m_SocialExchanges.Add(new SocialExchange(c));
                }
            }

        }

        /// <summary>
        /// Returns a DTO containing all the asset's configurations.
        /// </summary>
        public CommeillFautDTO GetDTO()
        {
            var at = m_SocialExchanges.Select(a => a.ToDTO()).ToArray();
          
            return new CommeillFautDTO() { _SocialExchangesDtos = at};
        }

   

        /// @cond DOXYGEN_SHOULD_SKIP_THIS

        protected override string OnAssetLoaded()
        {
            return null;
        }

        /// @endcond
    }

}

