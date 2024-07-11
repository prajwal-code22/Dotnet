namespace Students.Models{
    public class Student{
        public int sid{get;set;}
        public string name{get;set;}
        public Student(int sid,string name){
            this.sid=sid;
            this.name=name;
        }

    }
}