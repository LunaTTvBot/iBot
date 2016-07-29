﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using IBot.Core;
using IBot.Events;
using IBot.Events.Args.Users;
using IBot.Events.Commands;
using IBot.Facades.Core.Settings;
using NLog;
using CommandCreatorLocale = IBot.Resources.Plugins.CommandCreator.CommandCreatorLocale;

namespace IBot.Plugins.CommandCreator
{
    internal class CommandCreator : IPlugin
    {
        /**
     * CommandCreator Plugin by Lion Haupt
     * 
     * !command
     * -----
     * Params:
     * _TITLE_      string
     * _TEXT_       string
     * 
     * Commands:
     * !command                             - Description
     * !command create(_TITLE_) _Text_      - Creates a command with given _TEXT_
     * !command delete(_TITLE)              - Deletes command with _TITLE_
     * !command list                        - Lists all created commands
     * 
     */

        private const string CommandCreatePattern = @"^\s([a-zA-Z][a-zA-Z0-9_-]*)\s(.{2,})$";
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private static readonly Regex CommandCreateRegEx = new Regex(CommandCreatePattern);

        public string PluginName => CommandCreatorLocale.commandcreator_plugin_name;

        public void Init()
        {
            _logger.Debug("{0} {1}", PluginName, CommandCreatorLocale.commandcreator_plugin_loaded);
            CommandManager.RegisterPublicChannelCommand(new PublicChannelCommand
            {
                RegEx = "!command(.*)",
                Name = PluginName,
                //Action = CommandAction
            });

          
        }

    }
}
