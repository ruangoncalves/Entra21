using System;

namespace Domain
{
    public class Candidate
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public int Votes { get; private set; }

        public Candidate(string name, string cpf)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cpf = cpf;
            Votes = 0;
        }

        public void vote()
        {
            Votes++;
        }
        
    }

}