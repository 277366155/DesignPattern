using Newtonsoft.Json;

namespace XUnitTestPro
{
    /// <summary>
    /// 双向链表数据结构
    /// </summary>

    public class DulNode
    {
        public int Data { get; set; }
        public char DataChar { get { return (char)Data; } }
        [JsonIgnore]
        public DulNode Prior { get; set; }
        [JsonIgnore]
        public DulNode Next { get; set; }
    }
}
