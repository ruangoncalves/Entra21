using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Election
    {
        private  List<Candidate> _candidates {get; set;}
        public IReadOnlyCollection<Candidate> Candidates => _candidates;
        public Election()
        {
            var _candidates = new List<Candidate>();
        }
        
        public bool CreateCandidates(List<Candidate> candi, string password)
        {
            if (password == "Pa$$w0rd")
            {
                if(candi == null)
                {
                    return true;
                }
                _candidates = candi;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Vote(string cpf)
        {
            var candidate = _candidates.FirstOrDefault(x => x.CPF == cpf);
            if(candidate == null)
            {
                return false;
            }
            candidate.Vote();
            return true;
        }

        public List<Candidate> GetWinners()
        {
            var winners = new List<Candidate>{_candidates[0]};

            for (int i = 1; i < _candidates.Count; i++)
            {
                if (_candidates[i].Votes > winners[0].Votes)
                {
                    winners.Clear();
                    winners.Add(_candidates[i]);
                }
                else if (_candidates[i].Votes == winners[0].Votes)
                {
                    winners.Add(_candidates[i]);
                }
            }
            return winners;
        }
        
    }
}
