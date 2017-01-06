﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterface;
using ToolMangerInterface;

namespace DefaultTools
{
    public class Commandline : IFunction
    {
        public bool Active { get; set; }

        public string Author
        {
            get
            {
                return "Simon Aberle";
            }
        }

        private PluginContext _context;
        public PluginContext context
        {
            get
            {
                return _context;
            }
        }

        public string Description
        {
            get
            {
                return "Create a function performed by the commandline in Windows";
            }
        }

        public string DisplayName
        {
            get
            {
                return "Windows commandline";
            }
        }

        private Dictionary<string, string> _fileEndings;
        public Dictionary<string,string> FileEndings
        {
            get
            {
                return _fileEndings;
            }
        }

        private bool _initialized;
        public bool initialized
        {
            get
            {
                return _initialized;
            }
        }

        public string UniqueName
        {
            get
            {
                return "WindowsCommandLine";
            }
        }

        public Version Version
        {
            get
            {
                return new Version(1, 0, 0, 0);
            }
        }

        public event EventHandler<ErrorData> Error;

        public bool destroy()
        {
            return true;
        }

        public bool initialize()
        {
            _fileEndings = new Dictionary<string, string>();
            _fileEndings.Add("Commandline", ".cmd");
            _fileEndings.Add("Batch-File", ".bat");
            return true;
        }

        public bool Load()
        {
            return true;
        }

        public bool PerformeAction(PluginContext context)
        {
            return true;
        }

        public bool Save()
        {
            return true;
        }
    }
}
