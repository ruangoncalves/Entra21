using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Election
    {
        public Election()
        {
            var candidate = new List<Candidate>();
        }
        private  List<Candidate> candidate {get; set;}
        public IReadOnlyCollection<Candidate> Candidates => candidate;
        public bool CreateCandidates(List<Candidate> candi, string password)
        {
            if (password == "Pa$$w0rd")
            {
                if(candidate == null)
                {
                    return true;
                }
                candidate = candi;
                return true;
            }
            else
            {
                return false;
            }
        }

        // ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado
        public Guid GetCandidateIdByName(string name)
        {
            return candidate.First(x => x.Name == name).Id;
        }

        public Guid GetCandidateIdByCpf(string cpf)
        {
            return candidate.First(x => x.Cpf == cpf).Id;
        }

        public List<Candidate> GetWinners()
        {
            var winners = new List<Candidate>{candidate[0]};

            for (int i = 1; i < candidate.Count; i++)
            {
                if (candidate[i].Votes > winners[0].Votes)
                {
                    winners.Clear();
                    winners.Add(candidate[i]);
                }
                else if (candidate[i].Votes == winners[0].Votes)
                {
                    winners.Add(candidate[i]);
                }
            }
            return winners;
        }
        
    }
}
