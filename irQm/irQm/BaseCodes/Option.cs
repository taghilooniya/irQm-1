using System;
namespace irQm.BaseCodes
{
    public  class Option:IOption
    {
        string  Face { get; set; }
        
        bool IOption.IsTrue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
