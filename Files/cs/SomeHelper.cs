namespace Test
{
    using Terrasoft.Core.Factories;

    [DefaultBinding(typeof(ISomeHelper))]
    class SomeHelper : ISomeHelper
    {
        public string GetSomeString()
        {
            return "HelperString";
        }
    }
} 
 