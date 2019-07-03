namespace Bing.LogDashboard.Models
{
    /// <summary>
    /// 日志内容
    /// </summary>
    public interface ILogContent
    {
        /// <summary>
        /// 系统编号
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// 日志名称
        /// </summary>
        string LogName { get; set; }

        /// <summary>
        /// 日志级别
        /// </summary>
        string Level { get; set; }

        /// <summary>
        /// 跟踪号
        /// </summary>
        string TraceId { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        string OperationTime { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        string Duration { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        string Ip { get; set; }

        /// <summary>
        /// 主机
        /// </summary>
        string Host { get; set; }

        /// <summary>
        /// 线程号
        /// </summary>
        string ThreadId { get; set; }

        /// <summary>
        /// 浏览器
        /// </summary>
        string Browser { get; set; }

        /// <summary>
        /// 请求地址
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// 业务编号
        /// </summary>
        string BusinessId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        string Tenant { get; set; }

        /// <summary>
        /// 应用程序
        /// </summary>
        string Application { get; set; }

        /// <summary>
        /// 模块
        /// </summary>
        string Module { get; set; }

        /// <summary>
        /// 类名
        /// </summary>
        string Class { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        string Method { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        string Param { get; set; }

        /// <summary>
        /// 操作人编号
        /// </summary>
        string UserId { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        string Operator { get; set; }

        /// <summary>
        /// 操作人角色
        /// </summary>
        string Role { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        string Caption { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        string Content { get; set; }

        /// <summary>
        /// Sql语句
        /// </summary>
        string Sql { get; set; }

        /// <summary>
        /// Sql参数
        /// </summary>
        string SqlParams { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        string ErrorCode { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        string Exception { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        int Order { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        string FilePath { get; set; }
    }
}
