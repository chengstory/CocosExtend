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
    /// 自定义序列化器
    /// </summary>
    [Extension(typeof(IGameProjectSerializer))]
    public class FlatBuffersSerializer : IGameProjectSerializer
    {
        public string ID
        {
            get { return "CustomFB"; }
        }

        //显示在编辑器-〉项目设置-〉发布-〉自定义下拉框
        public string Label
        {
            get { return "CustomFlatBuffers"; }
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
            //csd路径
            string src = info.SourceFilePath;
            //转换以后文件的路径
            FilePath desFilePath = info.DestinationFilePath;
            //当前项目的资源路径
            string res = Services.ProjectOperations.CurrentSelectedSolution.ItemDirectory;

            //调用转换的代码可以写在这里

            return string.Empty;
        }


        /// <summary>
        /// 在序列化之前调用
        /// </summary>
        public void ContextInitialize(PublishInfo publishInfo)
        {

        }

        /// <summary>
        /// 序列化之后调用
        /// </summary>
        public void ContextFinalize(PublishInfo publishInfo)
        {

        }

    }
}
