        public static string ConfigurationPathAppData
        {
            get
            {
                string file = Path.Combine(ApplicationDataRootDirectory, @"00_AppCenter\Configuration\" + AppCenterConfigurationFileName);
                string directory = Path.GetDirectoryName(file);
                if (!Directory.Exists(directory))
                {
                    try
                    {
                        Directory.CreateDirectory(directory);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Das System konnte den geforderten Pfad nicht erzeugen.\n\rFehler: \n\r" + ex.ToString());
                    }
                }
                return file;
            }
        }

        public static string ApplicationDataRootDirectory
        {
            get
            {
                string directory = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), ProgrammName);
                if (!Directory.Exists(directory))
                {
                    try
                    {
                        Directory.CreateDirectory(directory);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Das System konnte den geforderten Pfad nicht erzeugen.\n\rFehler: \n\r" + ex.ToString());
                    }
                }

                return directory;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string ApplicationDataAddinsDirectory
        {
            get
            {
                string directory = Path.Combine(ApplicationDataRootDirectory, @"10_Apps");
                if (!Directory.Exists(directory))
                {
                    try
                    {
                        Directory.CreateDirectory(directory);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Das System konnte den geforderten Pfad nicht erzeugen.\n\rFehler: \n\r" + ex.ToString());
                    }
                }
                return directory;
            }
        }


