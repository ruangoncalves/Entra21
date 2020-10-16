using System.Collections.Generic;
using System.Linq;
using Domain;
using Xunit;

namespace urnaeletronica
{
    public class ElectionTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148.555-23");
            var candidates = new List<Candidate>{cand1};

            var created = election.CreateCandidates(candidates, "incorrect");

            Assert.Null(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148.555-23");
            var candidates = new List<Candidate>{cand1};
            
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            Assert.True(created);
            
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(cand1.Id, election.Candidates.ElementAt(0).Id);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148.555-23");
            var cand2 = new Candidate("Ana", "578.064.765-24");
            var candidates = new List<Candidate>{cand1,cand2} ;
            election.CreateCandidates(candidates, "Pa$$w0rd");

            Assert.NotEqual(cand1.Name, cand2.Name);
            Assert.NotEqual(cand1.CPF, cand2.CPF);
            Assert.NotEqual(cand1.Id, cand2.Id);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Jose()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148.555-23");
            var cand2 = new Candidate("Ana", "578.064.765-24");
            var candidates = new List<Candidate>{cand1,cand2};
            election.CreateCandidates(candidates, "Pa$$w0rd");

            election.Vote(cand1.CPF);

            var cJose = election.Candidates.First(x => x.Id == cand1.Id);
            var cAna = election.Candidates.First(x => x.Id == cand2.Id);
            Assert.Equal(1, cJose.Votes);
            Assert.Equal(0, cAna.Votes);
        }

        [Fact]
        public void Should_return_false_and_not_vote_when_CPF_is_invalid()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148.555-23");
            var candidates = new List<Candidate>{cand1};

            election.CreateCandidates(candidates, "Pa$$w0rd");

            var voteResult = election.Vote("1321");

            var candidateJose = election.Candidates.First(x => x.Id == cand1.Id);
            Assert.Equal(0, candidateJose.Votes);
            Assert.False(voteResult);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148.555-23");
            var cand2 = new Candidate("Ana", "578.064.765-24");
            var candidates = new List<Candidate>{cand1,cand2};
            election.CreateCandidates(candidates, "Pa$$w0rd");
                        
            election.Vote(cand2.CPF);

            var winners = election.GetWinners();
            var wCount = winners.Count;

            Assert.Equal(1, wCount);
            Assert.Equal(cand2.Id, winners.ElementAt(0).Id);
            Assert.Equal(1, winners.ElementAt(0).Votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148.555-23");
            var cand2 = new Candidate("Ana", "578.064.765-24");
            var candidates = new List<Candidate>{cand1,cand2};
            election.CreateCandidates(candidates, "Pa$$w0rd");
                        
            election.Vote(cand1.CPF);
            election.Vote(cand2.CPF);

            var winners = election.GetWinners();
            var expected = new List<Candidate>{cand1,cand2};

            Assert.Equal(2, winners.Count);
            Assert.Equal(expected, winners);
        }
    }
}
