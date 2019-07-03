using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Bing.LogDashboard.Models;
using Xunit;
using Xunit.Abstractions;

namespace Bing.LogDashboard.Test
{
    public class LogContentTest:TestBase
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        private readonly string _filePath = @"D:\test\Utopa.Tms\Trace\2019-06-28\Trace.0.log";

        /// <summary>
        /// 分隔符
        /// </summary>
        public const string Separetor =
            "-----------------------------------------------------------------------------------------------------------------------------\n\n";

        public LogContentTest(ITestOutputHelper output) : base(output)
        {
        }

        

        [Fact]
        public void Test_FileContentSplit()
        {
            var text = File.ReadAllText(_filePath);
            var contents = text.Split(Separetor);
            var logContents = new List<LogContent>();
            foreach (var content in contents)
            {
                if (string.IsNullOrWhiteSpace(content))
                {
                    continue;
                }
                var lines = content.Split('\n');
                var logContent = new LogContent();
                var sb = new StringBuilder();
                for (var i = 0; i < lines.Length; i++)
                {
                    // 添加当前行数据
                    sb.AppendLine(lines[i]);
                    // 如果有下一行，则进行判断下一行是否多行文本
                    if (i + 1 < lines.Length)
                    {
                        // 如果是多行文本，则不做任何操作
                        // 如果是单行文本，则清空数据，并赋值
                        if (!IsMultiLineText(lines[i + 1]))
                        {
                            logContent.Content = sb.ToString();
                            sb.Clear();
                        }
                    }
                    else if(i+1==lines.Length)
                    {
                        logContent.Content = sb.ToString();
                        sb.Clear();
                    }
                }
                logContents.Add(logContent);
            }
        }

        /// <summary>
        /// 是否多行文本
        /// </summary>
        /// <param name="content">内容</param>
        private bool IsMultiLineText(string content)
        {
            return !Regex.IsMatch(content, @"^\d{1,2}\.\s");
        }

        /// <summary>
        /// 是否目标行
        /// </summary>
        /// <param name="key">键名</param>
        /// <param name="content">内容</param>
        private bool IsTargetLine(string key, string content)
        {
            return Regex.IsMatch(content, @"^\d{1,2}\.\s" + key);
        }

        /// <summary>
        /// 获取操作时间
        /// </summary>
        /// <param name="content">内容</param>
        private string GetOperationTime(string content)
        {
            var match = Regex.Match(content, @"操作时间:\s\d{4}-\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2}.\d{1,3}");
            if (match.Success)
            {
                return match.Value.Replace("操作时间", "");
            }

            return string.Empty;
        }

        private string GetKey(string content)
        {
            var match = Regex.Match(content, @"^\d{1,2}\. (([\u4e00-\u9fa5]|[A-Za-z]){0,})");
            if (match.Success)
            {
                return Regex.Replace(match.Value, @"^\d{1,2}\.\s", "");
            }

            return string.Empty;
        }
    }
}
