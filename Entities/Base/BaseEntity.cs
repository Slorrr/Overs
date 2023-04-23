namespace hackathon_21._04._23
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<Sign> Signs { get; set; }
        public List<Condition> Conditions { get; set; }

        public BaseEntity() 
        {

        }

        public void AddSign(Sign sign) 
        {
            Signs.Add(sign);
        }
        public void RemoveSign(int ID)
        {
            for (int i = 0; i < Signs.Count; i++)
            {
                if (Signs[i].Id==ID)
                {
                    Signs.Remove(Signs[i]);
                }
            }
        }

        public void AddCondition(Condition condition)
        {
            Conditions.Add(condition);
        }
        public void RemoveCondition(int ID)
        {
            for (int i = 0; i < Conditions.Count; i++)
            {
                if (Conditions[i].Id == ID)
                {
                    Conditions.Remove(Conditions[i]);
                }
            }
        }
    }
}
