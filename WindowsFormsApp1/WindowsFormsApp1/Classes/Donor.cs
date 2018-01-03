﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Donor
    {
        string ime;
        string prezime;
        int oib;
        int godine;
        string grad;
        int br_mobitela;
        DateTime datum;
        Krvna_grupa krvna_grupa;
        Spol spol;
    }

    enum Krvna_grupa
    {
        0-
        0+
        A-
        A+
        B-
        B+
        AB-
        AB+
        }
    enum Spol
    {
        musko
        zensko
    }
}