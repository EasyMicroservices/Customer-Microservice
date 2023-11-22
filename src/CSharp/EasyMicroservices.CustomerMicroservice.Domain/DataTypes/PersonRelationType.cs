namespace EasyMicroservices.CustomerMicroservice.DataTypes
{
    public enum PersonRelationType : byte
    {
        /// <summary>
        /// value is none, Never use the None to return values
        /// </summary>
        None = 0,
        /// <summary>
        /// error value is default
        /// </summary>
        Default = 1,
        /// <summary>
        /// for the filter values from web admin panel you can sent all for types
        /// </summary>
        All = 2,
        /// <summary>
        /// there is other error that is not in the types
        /// </summary>
        Other = 3,
        /// <summary>
        /// the error type is uknown to us
        /// </summary>
        Unknown = 4,
        /// <summary>
        /// there is nothing to show or validate error
        /// </summary>
        Nothing = 5,
        Father = 6,
        Mother = 7,
        Sister = 8,
        Brother = 9,
        StepMother = 10,
        StepFather = 11,
        StepBrother = 12,
        GrandMother = 13,
        GrandFather = 14,
        Aunt = 15,
        Cousin = 16,
        Spouses = 17,
        Friend = 18,
        Moderator = 19
    }
}