﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Logic
{
    public class BusinessRules
    {
        //SELECT_CURSOS INSCRIBIRSE
        public static List<Curso> ValidarCursosAlumnos(List<Curso> listaCursos)
        {
            //Quita cursos en los que la materia no es del plan del alumno
            if (listaCursos.Count != 0)
            {
                listaCursos = ValidarMateriaPlan(listaCursos);
            }
            //Quita cursos en los que ya esta inscripto o es de una materia ya insripta
            if (listaCursos.Count != 0)
            {
                listaCursos = ValidarYaInsAlu(listaCursos);
            }
            //Quita cursos que ya no tengan cupos
            if (listaCursos.Count != 0)
            {
                listaCursos = ValidarCupo(listaCursos);
            }            
            
            
            return listaCursos;
        }
        public static List<Curso> ValidarCupo(List<Curso> listaCursos)
        {
            //Consultar a la base todas las incripciones para este año
            List<Inscripciones> listaInsAlu = Alumnos_inscripcionesLogic.GetInstance().GetAllYear(Int32.Parse(DateTime.Now.ToString("yyyy")));
            foreach (var insAlu in listaInsAlu) {

                listaCursos.RemoveAll(item => item.id_curso == insAlu.IdCurso);
            }            
            return listaCursos;
            
            //sacar los cursos de listaCursos en los que los cupos > a count(inscripciones de ese curso)
            //foreach para cada curso foreach de insciociones contando para ese curso
            
        }
        public static List<Curso> ValidarYaInsAlu(List<Curso> listaCursos) 
        {
            //Consultar a la base todos los cursos en los que el alumno ya se inscribio este año
            List<Curso> cursosInscripto = CursoLogic.GetInstance().GetAllYearAlum(Session.currentUser.IdPersona, Int32.Parse(DateTime.Now.ToString("yyyy")));
            foreach (var insAlu in cursosInscripto)
            {

                listaCursos.RemoveAll(item => item.id_curso == insAlu.id_curso || item.id_materia == insAlu.id_materia);
            }            
            return listaCursos;
        }
        public static List<Curso> ValidarMateriaPlan(List<Curso> listaCursos)
        {
            //Trae de la base de datos las materias del plan del alumno
            List<Materia> materiasPlan = MateriaLogic.GetInstance().GetAllPlan(Session.currentUser.IdPlan);
            foreach (var materias in materiasPlan)
            {
                listaCursos.RemoveAll(item => item.id_materia != materias.ID);
            }
            return listaCursos;            
        }

        //INSCRIPCIONES_ALUMNOS_DESKTOP 
        public static bool ValidarCampos(string[] labels)//agarra todos los txt que le mandes y se fija si tienen texto
        {
            foreach (string labelPosicion in labels)
            {                
                if (String.IsNullOrWhiteSpace(labelPosicion))
                {                    
                    return false;
                }
            }
            return true;
        }
    }
}