﻿using OpenMB.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMB.Script.Command
{
    public class VectorSetZScriptCommand : ScriptCommand
    {
        public VectorSetZScriptCommand()
        {
            commandArgs = new string[] {
                "Vector",
                "Value"
            };
        }
        private string[] commandArgs;
        public override string[] CommandArgs
        {
            get
            {
                return commandArgs;
            }
        }

        public override string CommandName
        {
            get
            {
                return "vector_set_z";
            }
        }

        public override ScriptCommandType CommandType
        {
            get
            {
                return ScriptCommandType.Line;
            }
        }

        public override void Execute(params object[] executeArgs)
        {
            GameWorld world = executeArgs[0] as GameWorld;
            string vectorVariable = CommandArgs[0].ToString();
            string value = CommandArgs[1].ToString();

            ScriptLinkTableNode vector = world.GlobalValueTable.GetRecord(vectorVariable);
            if (vector != null)
            {
                vector.NextNodes[2].Value = value.StartsWith("%") ? Context.GetLocalValue(value.Substring(1)) : value;
            }
        }
    }
}
