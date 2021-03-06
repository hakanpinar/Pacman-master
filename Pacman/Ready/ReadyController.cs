﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public class ReadyController
    {
        ReadyModel readyModel;
        ReadyUI readyUI;

        public ReadyController()
        {
            readyModel = new ReadyModel();
            readyUI = new ReadyUI();
        }
        
        public ReadyModel Model
        {
            get { return this.readyModel; }
            set { this.readyModel = value; }
        }

        public ReadyUI view
        {
            get { return readyUI; }
        }


        public void isGameStarted()
        {
           
            if (readyModel.gameStarted == false)
            {
            
                readyUI.Visible = false;
                readyModel.gameStarted = true;
              
            }
        }

    }
}
