using System.Runtime.Serialization;

namespace ConsoleApplication1
{
    [DataContract]
    public class FooBar
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public bool IsFoo { get; set; }

        [DataMember]
        public bool IsBar { get; set; }
    }
}
