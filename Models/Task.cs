namespace Dot_Net_To_Do_List.Models
{
    public class Task
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        public Boolean IsCompleted { get; set; }
        public DateTime CreationDate { get; set; }
        

        public Task()
        {

        }
    }

}
