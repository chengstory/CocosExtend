/*
 * Copyright (c) 2015 Chukong Technologies Inc.
 * http://www.cocos.org
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using CocoStudio.Core;
using CocoStudio.Projects;
using Mono.Addins;
using MonoDevelop.Core;
using System.Runtime.InteropServices;

namespace CocoStudio.Model.ExtensionModel
{
    /// <summary>
    /// Custom Serializer
    /// </summary>
    [Extension(typeof(IGameProjectSerializer))]
    public class FlatBuffersSerializer : IGameProjectSerializer
    {
        public string ID
        {
            get { return "CustomSer"; }
        }

        //Project->Project Setting...->Publish->Custom
        public string Label
        {
            get { return "CustomSerializer"; }
        }

        public FlatBuffersSerializer()
        {

        }

        /// <summary>
        /// Serialize function
        /// </summary>
        /// <param name="info">info of Publish</param>
        /// <param name="projFile">Project file</param>
        /// <returns>error info</returns>
        public string Serialize(PublishInfo info, IProjectFile projFile)
        {
            //csd fullpath
            string src = info.SourceFilePath;
            //des fullpath
            FilePath desFilePath = info.DestinationFilePath;
            //resources fullpath
            string res = Services.ProjectOperations.CurrentSelectedSolution.ItemDirectory;

            //serialize code

            return "";
        }


        /// <summary>
        /// ContextInitialize is called before Serialize
        /// </summary>
        public void ContextInitialize(PublishInfo publishInfo)
        {

        }

        /// <summary>
        /// ContextInitialize is called after Serialize
        /// </summary>
        public void ContextFinalize(PublishInfo publishInfo)
        {

        }

    }
}
