﻿using System.Windows.Input;

namespace StarlightDirector.UI.Windows {
    partial class MainWindow {

        public static readonly ICommand CmdEditSelectAll = CommandHelper.RegisterCommand("Ctrl+A");

        private void CmdEditSelectAll_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = Editor.ScoreNotes.Count > 0;
        }

        private void CmdEditSelectAll_Executed(object sender, ExecutedRoutedEventArgs e) {
            Editor.SelectAllScoreNotes();
        }

    }
}
