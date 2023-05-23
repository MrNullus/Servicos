using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicos
{
    //[Route("api/[controller]")] (*apago essa routa)


    [ApiController]
    public class AlunoController : ControllerBase
    {
        List<Student> alunos = new List<Student>();



        public AlunoController()
        {

           alunos.Add(new Student { Nome = "João", Idade = 80, Id = 1 });
           alunos.Add(new Student { Nome = "Maria", Idade = 84, Id = 2 });
           alunos.Add(new Student { Nome = "José", Idade = 88, Id = 3 });
           alunos.Add(new Student { Nome = "Raimundo",Idade = 92, Id = 4 });
           alunos.Add(new Student { Nome = "Manoel", Idade = 96, Id = 5 });
           alunos.Add(new Student { Nome = "Francisco", Idade = 100, Id = 6 });
           alunos.Add(new Student { Nome = "Joaquim", Idade = 104, Id = 7 });
           alunos.Add(new Student { Nome = "Enzo", Idade = 108, Id = 8 });
       

        }

        [Route("getAllNames")]
        [HttpGet]
        public List<Student> GetAllAlunos()
        {
            return alunos;
        }

        [Route("getNameById")]
        [HttpGet]
        public Student GetNameById(int id)
        {
            return alunos.Where(x => x.Id == id).FirstOrDefault();
        }

        [Route("insertStudentByPost")]
        [HttpPost]
        public List<Student> InsertStudentByPost(Student aluno)
        {
            if (aluno != null)
            {
                alunos.Add(aluno);
            }

            return alunos;
        }

        [Route("insertStudentByPut")]
        [HttpPut]
        public List<Student> InsertStudentByPut(Student aluno)
        {
            if (aluno != null)
            {
                alunos.Add(aluno);
            }

            return alunos;
        }

        [Route("checkStudentById")]
        [HttpGet]
        public bool VerificarAlunoPorId(int Id)
        {
            return alunos.Where(aluno => aluno.Id == Id).Any();
        }
    }



    public class Student
    {
        public int Id { get; set; }

        public int Idade { get; set; }

        public string Nome { get; set; }
    }


}

    
    


