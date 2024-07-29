using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDs
{
    /* Dependency Inversion Principle - DIP
     * High level module should not depends on low level module.
     * Both should depend on abstraction.
     * 
     */

    // Violates DIP
    class FileManager
    {
        private FileSystem _fileSystem;

        public FileManager()
        {
            _fileSystem = new FileSystem(); //High level depends on low level.
        }

    }

    class FileSystem
    {
        void Read(string path)
        {
            Console.WriteLine("Read");
        }
    }

    interface IFileSystem
    {
        void Read();
    }

    class FileOperate : IFileSystem
    {
        public void Read()
        {
            Console.WriteLine("Read");
        }
    }
    class FileServer
    {
        private IFileSystem _fileOperator;

        public FileServer(IFileSystem fileOperator)
        {
            _fileOperator = fileOperator;
        }

    }
}
