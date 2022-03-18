namespace ScuffedWalls
{
    public partial class Config
    {
        public bool HideMapInRPC;
        public string MapFolderPath;
        public string SWFilePath;
        public string InfoPath;
        public string MapFilePath;
        public string OldMapPath;
        public bool ClearConsoleOnRefresh;
        public bool IsAutoImportEnabled;
        public bool IsBackupEnabled;
        public bool Debug;
        public bool IsAutoSimplifyPointDefinitionsEnabled;
        public bool PrettyPrintJson;
        public Backup BackupPaths = new Backup();
        public bool Unattended = false;
        public class Backup
        {
            public string BackupFolderPath;
            public string BackupSWFolderPath;
            public string BackupMAPFolderPath;
        }

    }



}
