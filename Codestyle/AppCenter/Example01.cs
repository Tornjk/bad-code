 /// <summary>
        /// Altdaten löschen
        /// </summary>
        /// <param name="addInDirectory"></param>
        private bool ClearAddinsDirectory(string addInDirectory)
        {
            // ToDo Übersetzung --> erledigt
            string appsClearDelete = Translator.Translate(TranslatorKeys.CLEARAPPSDIRECTORY_TEXT);

            try
            {
                DirectoryInfo dir = new DirectoryInfo(addInDirectory);
                if (dir.Exists)
                    Directory.Delete(addInDirectory, true);

                LogManagerAPC.Instance.AddLogMessage(new LogMessage(LogType.Info, appsClearDelete + ": " + Translator.Translate(TranslatorKeys.SUCCESSFULL_TEXT)));

                return true;
            }
            catch (PathTooLongException ex)
            {
                LogManagerAPC.Instance.AddLogMessage(new LogMessage(LogType.Error, appsClearDelete + ": " + Translator.Translate(TranslatorKeys.PATHTOLONG_TEXT) + System.Environment.NewLine +
                   Translator.Translate(TranslatorKeys.PATH_TEXT) + ": " + addInDirectory + Translator.Translate(TranslatorKeys.EXCEPTION_TEXT) + ex.ToString()));
            }
            catch (DirectoryNotFoundException ex)
            {
                LogManagerAPC.Instance.AddLogMessage(new LogMessage(LogType.Error, appsClearDelete + ": " + Translator.Translate(TranslatorKeys.DIRNOTFOUND_TEXT) + System.Environment.NewLine +
                   Translator.Translate(TranslatorKeys.PATH_TEXT) + ": " + addInDirectory + Translator.Translate(TranslatorKeys.EXCEPTION_TEXT) + ex.ToString()));
            }
            catch (IOException ex)
            {
                LogManagerAPC.Instance.AddLogMessage(new LogMessage(LogType.Error, appsClearDelete + ": " + Translator.Translate(TranslatorKeys.DELETE_IOException_TEXT) + System.Environment.NewLine +
                   Translator.Translate(TranslatorKeys.PATH_TEXT) + ": " + addInDirectory + Translator.Translate(TranslatorKeys.EXCEPTION_TEXT) + ex.ToString()));
            }
            catch (UnauthorizedAccessException ex)
            {
                LogManagerAPC.Instance.AddLogMessage(new LogMessage(LogType.Error, appsClearDelete + ": " + Translator.Translate(TranslatorKeys.UNAUTHACCESS_TEXT) + System.Environment.NewLine +
                   Translator.Translate(TranslatorKeys.PATH_TEXT) + ": " + addInDirectory + Translator.Translate(TranslatorKeys.EXCEPTION_TEXT) + ex.ToString()));
            }
            catch (Exception ex)
            {
                LogManagerAPC.Instance.AddLogMessage(new LogMessage(LogType.Info, appsClearDelete + System.Environment.NewLine +
                   Translator.Translate(TranslatorKeys.PATH_TEXT) + ": " + addInDirectory + Translator.Translate(TranslatorKeys.EXCEPTION_TEXT) + ": " + ex.ToString()));
            }

            return false;
        }
