using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestPro
{
    public class DataStructureTest
    {
        ITestOutputHelper _output;
        public DataStructureTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory(DisplayName = "双向链表")]
        [InlineData(4)]
        [InlineData(-4)]
        public void Test1(int num)
        {
            var length = 26;
            DulNode[] arr = new DulNode[length];            
            for (var i = 0; i < length; i++)
            {
                arr[i] = new DulNode();

                if (i == 0)
                {
                    arr[i].Data = (int)'a';
                }
                else
                {
                    arr[i].Data = arr[i - 1].Data + 1;
                    arr[i - 1].Next = arr[i];
                    arr[i].Prior = arr[i - 1];
                    if (i == length - 1)
                    {
                        arr[0].Prior = arr[i];
                        arr[i].Next = arr[0];
                    }
                }
            }

            _output.WriteLine("当前链表为："+JsonConvert.SerializeObject(arr));

            DulNode currentNode = arr[0] ;
            if (num > 0)
            {
                for (var i = 0; i < num; i++)
                    currentNode = currentNode.Next;
            }
            else if (num < 0)
            {
                for(var i =0;i>num;i--)
                    currentNode = currentNode.Prior;
            }

            for (var i = 0; i < length; i++)
            {
                _output.WriteLine(currentNode.DataChar.ToString());
                currentNode = currentNode.Next;
            }
        }
    }
}
