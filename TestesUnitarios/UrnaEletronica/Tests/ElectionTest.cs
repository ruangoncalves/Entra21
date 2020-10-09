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
            var cand1 = new Candidate("José", "025.148");
            var candidates = new List<Candidate>{cand1};

            var created = election.CreateCandidates(candidates, "incorrect");

            Assert.Empty(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148");
            var candidates = new List<Candidate>{cand1};
            
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            Assert.True(created);
            
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal("José", cand1.Name);
            Assert.Equal("025.148", cand1.Cpf);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148");
            var cand2 = new Candidate("Ana", "578.064");
            var candidates = new List<Candidate>{cand1,cand2} ;
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            var candidateJose = election.GetCandidateIdByName(cand1.Name);
            var candidateAna = election.GetCandidateIdByName(cand2.Name);

            var cpfJose = election.GetCandidateIdByCpf(cand1.Cpf);
            var cpfAna = election.GetCandidateIdByCpf(cand2.Cpf);

            Assert.NotEqual(candidateAna, candidateJose);
            Assert.NotEqual(cpfAna, cpfJose);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Jose()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148");
            var cand2 = new Candidate("Ana", "578.064");
            var candidates = new List<Candidate>{cand1,cand2};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var joaoId = election.GetCandidateIdByName(cand1.Name);
            var anaId = election.GetCandidateIdByName(cand2.Name);

            var cpfFernando = election.GetCandidateIdByCpf(cand1.Cpf);
            var cpfAna = election.GetCandidateIdByCpf(cand2.Cpf);

            cand1.vote();
            cand1.vote();

            Assert.Equal(2, cand1.Votes);
            Assert.Equal(0, cand2.Votes);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            var election = new Election();
            var cand1 = new Candidate("José", "025.148");
            var cand2 = new Candidate("Ana", "578.064");
            var candidates = new List<Candidate>{cand1,cand2};
            election.CreateCandidates(candidates, "Pa$$w0rd");;
                        
            cand2.vote();
            cand2.vote();
            var winners = election.GetWinners();

            var winnersCounter = winners.Count;

            Assert.Equal(1, winnersCounter);
            Assert.Equal(cand2.Id, winners.ElementAt(0).Id);
            Assert.Equal(2, winners.ElementAt(0).Votes);
        }

        // [Fact]
        // public void should_return_both_candidates_when_occurs_draw()
        // {
        //     // Dado / Setup
        //     // OBJETO election
        //     var election = new Election();
        //     string fernando = "Fernando";
        //     string ana = "Ana";
        //     var candidates = new List<string>{fernando, ana};
        //     election.CreateCandidates(candidates, "Pa$$w0rd");
        //     var fernandoId = election.GetCandidateIdByName(fernando);
        //     var anaId = election.GetCandidateIdByName(ana);
            
        //     // Quando / Ação
        //     // Estamos acessando o MÉTODO ShowMenu do OBJETO election
        //     election.Vote(anaId);
        //     election.Vote(fernandoId);
        //     var winners = election.GetWinners();

        //     // Deve / Asserções
        //     var candidateFernando = winners.Find(x => x.id == fernandoId);
        //     var candidateAna = winners.Find(x => x.id == anaId);
        //     Assert.Equal(1, candidateFernando.votes);
        //     Assert.Equal(1, candidateAna.votes);
        // }

        // [Fact]
        // public void should_return_the_candidate_to_CPF()
        // {
        //     // Dado / Setup
        //     // OBJETO election
        //     var election = new Exercises();
        //     var joaoA = "João A";
        //     var cpfA = "005.012";
        //     var joaoB = "João B";
        //     var cpfB = "109.432";
        //     var joaoC = "João C";
        //     var cpfC = "944.025";
        //     var candidates = new List<(string name, string cpf)>{(joaoA,cpfA),(joaoB,cpfB),(joaoC,cpfC)};
            
        //     election.CreateCandidates(candidates, "Pa$$w0rd");
        //     var fernandoId = election.GetCandidateIdByName(fernando);
        //     var anaId = election.GetCandidateIdByName(ana);
            
        //     // Quando / Ação
        //     // Estamos acessando o MÉTODO ShowMenu do OBJETO election
        //     election.Vote(anaId);
        //     election.Vote(fernandoId);
        //     var winners = election.GetWinners();

        //     // Deve / Asserções
        //     var candidateFernando = winners.Find(x => x.id == fernandoId);
        //     var candidateAna = winners.Find(x => x.id == anaId);
        //     Assert.Equal(1, candidateFernando.votes);
        //     Assert.Equal(1, candidateAna.votes);
        // }
    }
}
