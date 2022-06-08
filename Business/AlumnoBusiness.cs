﻿using Data;
using Entity;
using NLog;
using System;

namespace Business
{
    public class AlumnoBusiness
    {
        private readonly AlumnoData alumnoData = new AlumnoData();
        private readonly Logger logger = LogManager.GetCurrentClassLogger();


        public object BusinessAlumno(GeneralEntity genEnt)
        {
            try
            {

                return alumnoData.DataAlumno(genEnt);

            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;

            }
        }
    }
}
