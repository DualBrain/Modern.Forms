﻿using System;
using System.Threading;
using Avalonia.Input;
using Avalonia.Threading;

namespace Modern.Forms
{
    public static class Application
    {
        private static CancellationTokenSource? _mainLoopCancellationTokenSource;
        private static bool is_exiting;

        // This is the top level active menu, if any.  
        // This is used to hide menus if the user clicks elsewhere on the Form or off the Form
        internal static MenuBase? ActiveMenu { get; set; }

        /// <summary>
        /// Sent when the application is exiting.
        /// </summary>
        public static event EventHandler? OnExit;

        public static void Run (Form form)
        {
            form.Show ();
            Run ((ICloseable)form);
        }

        /// <summary>
        /// Runs the application's main loop until the <see cref="ICloseable"/> is closed.
        /// </summary>
        /// <param name="closable">The closable to track</param>
        public static void Run (ICloseable closable)
        {
            if (_mainLoopCancellationTokenSource != null)
                throw new Exception ("Run should only called once");

            closable.Closed += (s, e) => Exit ();

            _mainLoopCancellationTokenSource = new CancellationTokenSource ();

            Dispatcher.UIThread.MainLoop (_mainLoopCancellationTokenSource.Token);

            // Make sure we call OnExit in case an error happened and Exit() wasn't called explicitly
            if (!is_exiting)
                OnExit?.Invoke (null, EventArgs.Empty);
        }

        public static void RunOnUIThread (Action action)
        {
            Dispatcher.UIThread.Post (action);
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        public static void Exit ()
        {
            is_exiting = true;

            OnExit?.Invoke (null, EventArgs.Empty);

            _mainLoopCancellationTokenSource?.Cancel ();
        }
    }
}
