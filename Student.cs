using Amazon.DynamoDBv2.DataModel;
namespace WebApplication5
{
    [DynamoDBTable("Student")]
    public class Student
    {
        [DynamoDBHashKey]
        public string StudentId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Class
        {
            get;
            set;
        }
        public int Physics
        {
            get;
            set;
        }
        public int Maths
        {
            get;
            set;
        }
        public int Chemistry
        {
            get;
            set;
        }
        public int IsDeleted
        {
            get;
            set;
        }
    }
}
