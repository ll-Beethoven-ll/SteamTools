#nullable enable
#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable SA1634 // File header should show copyright
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
#pragma warning disable CS0108 // 成员隐藏继承的成员；缺少关键字 new
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由包 BD.Common.Settings.V4.SourceGenerator.Tools 源生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using static BD.WTTS.Settings.Abstractions.IProxySettings;

// ReSharper disable once CheckNamespace
namespace BD.WTTS.Settings;

[JsonSourceGenerationOptions(WriteIndented = true, IgnoreReadOnlyProperties = true)]
[JsonSerializable(typeof(ProxySettings_))]
internal partial class ProxySettingsContext : JsonSerializerContext
{
    static ProxySettingsContext? instance;

    public static ProxySettingsContext Instance
        => instance ??= new ProxySettingsContext(ISettings.GetDefaultOptions());
}

[MPObj, MP2Obj(SerializeLayout.Explicit)]
public sealed partial class ProxySettings_ : IProxySettings, ISettings, ISettings<ProxySettings_>
{
    public const string Name = nameof(ProxySettings);

    static string ISettings.Name => Name;

    static JsonSerializerContext ISettings.JsonSerializerContext
        => ProxySettingsContext.Instance;

    static JsonTypeInfo ISettings.JsonTypeInfo
        => ProxySettingsContext.Instance.ProxySettings_;

    static JsonTypeInfo<ProxySettings_> ISettings<ProxySettings_>.JsonTypeInfo
        => ProxySettingsContext.Instance.ProxySettings_;

    /// <summary>
    /// 启用脚本自动检查更新
    /// </summary>
    [MPKey(0), MP2Key(0), JsonPropertyOrder(0)]
    public bool IsAutoCheckScriptUpdate { get; set; } = IProxySettings.DefaultIsAutoCheckScriptUpdate;

    /// <summary>
    /// 启用代理脚本
    /// </summary>
    [MPKey(1), MP2Key(1), JsonPropertyOrder(1)]
    public bool IsEnableScript { get; set; } = IProxySettings.DefaultIsEnableScript;

    /// <summary>
    /// 代理服务启用状态
    /// </summary>
    [MPKey(2), MP2Key(2), JsonPropertyOrder(2)]
    public IReadOnlyCollection<string>? SupportProxyServicesStatus { get; set; } = IProxySettings.DefaultSupportProxyServicesStatus;

    /// <summary>
    /// 脚本启用状态
    /// </summary>
    [MPKey(3), MP2Key(3), JsonPropertyOrder(3)]
    public IReadOnlyCollection<int>? ScriptsStatus { get; set; } = IProxySettings.DefaultScriptsStatus;

    #region 代理设置

    /// <summary>
    /// 程序启动时自动启动代理
    /// </summary>
    [MPKey(4), MP2Key(4), JsonPropertyOrder(4)]
    public bool ProgramStartupRunProxy { get; set; } = IProxySettings.DefaultProgramStartupRunProxy;

    /// <summary>
    /// 系统代理模式端口
    /// </summary>
    [MPKey(5), MP2Key(5), JsonPropertyOrder(5)]
    public ushort SystemProxyPortId { get; set; } = IProxySettings.DefaultSystemProxyPortId;

    /// <summary>
    /// 系统代理模式IP
    /// </summary>
    [MPKey(6), MP2Key(6), JsonPropertyOrder(6)]
    public string? SystemProxyIp { get; set; } = IProxySettings.DefaultSystemProxyIp;

    /// <summary>
    /// 开启加速后仅代理脚本而不加速
    /// </summary>
    [MPKey(7), MP2Key(7), JsonPropertyOrder(7)]
    public bool OnlyEnableProxyScript { get; set; } = IProxySettings.DefaultOnlyEnableProxyScript;

    /// <summary>
    /// 代理时使用的解析主DNS
    /// </summary>
    [MPKey(8), MP2Key(8), JsonPropertyOrder(8)]
    public string? ProxyMasterDns { get; set; } = IProxySettings.DefaultProxyMasterDns;

    /// <summary>
    /// 启用 Http 链接转发到 Https
    /// </summary>
    [MPKey(9), MP2Key(9), JsonPropertyOrder(9)]
    public bool EnableHttpProxyToHttps { get; set; } = IProxySettings.DefaultEnableHttpProxyToHttps;

    #endregion

    #region 本地代理设置

    /// <summary>
    /// Socks5 Enable
    /// </summary>
    [MPKey(10), MP2Key(10), JsonPropertyOrder(10)]
    public bool Socks5ProxyEnable { get; set; } = IProxySettings.DefaultSocks5ProxyEnable;

    /// <summary>
    /// Socks5 监听端口
    /// </summary>
    [MPKey(11), MP2Key(11), JsonPropertyOrder(11)]
    public ushort Socks5ProxyPortId { get; set; } = IProxySettings.DefaultSocks5ProxyPortId;

    #endregion

    #region 二级代理设置

    /// <summary>
    /// TwoLevelAgent Enable
    /// </summary>
    [MPKey(12), MP2Key(12), JsonPropertyOrder(12)]
    public bool TwoLevelAgentEnable { get; set; } = IProxySettings.DefaultTwoLevelAgentEnable;

    /// <summary>
    /// TwoLevelAgent ProxyType
    /// </summary>
    [MPKey(13), MP2Key(13), JsonPropertyOrder(13)]
    public ExternalProxyType TwoLevelAgentProxyType { get; set; } = IProxySettings.DefaultTwoLevelAgentProxyType;

    /// <summary>
    /// 二级代理 IP
    /// </summary>
    [MPKey(14), MP2Key(14), JsonPropertyOrder(14)]
    public string? TwoLevelAgentIp { get; set; } = IProxySettings.DefaultTwoLevelAgentIp;

    /// <summary>
    /// 二级代理 监听端口
    /// </summary>
    [MPKey(15), MP2Key(15), JsonPropertyOrder(15)]
    public ushort TwoLevelAgentPortId { get; set; } = IProxySettings.DefaultTwoLevelAgentPortId;

    /// <summary>
    /// TwoLevelAgent UserName
    /// </summary>
    [MPKey(16), MP2Key(16), JsonPropertyOrder(16)]
    public string? TwoLevelAgentUserName { get; set; } = IProxySettings.DefaultTwoLevelAgentUserName;

    /// <summary>
    /// TwoLevelAgent Password
    /// </summary>
    [MPKey(17), MP2Key(17), JsonPropertyOrder(17)]
    public string? TwoLevelAgentPassword { get; set; } = IProxySettings.DefaultTwoLevelAgentPassword;

    #endregion

    #region 代理模式设置

    /// <summary>
    /// 当前代理模式
    /// </summary>
    [MPKey(18), MP2Key(18), JsonPropertyOrder(18)]
    public ProxyMode ProxyMode { get; set; } = IProxySettings.DefaultProxyMode;

    #endregion

    /// <summary>
    /// 启用 GOG 插件代理
    /// </summary>
    [MPKey(19), MP2Key(19), JsonPropertyOrder(19)]
    public bool IsProxyGOG { get; set; } = IProxySettings.DefaultIsProxyGOG;

    /// <summary>
    /// 是否只针对 Steam 内置浏览器启用脚本
    /// </summary>
    [MPKey(20), MP2Key(20), JsonPropertyOrder(20)]
    public bool IsOnlyWorkSteamBrowser { get; set; } = IProxySettings.DefaultIsOnlyWorkSteamBrowser;

    /// <summary>
    /// 启用 DNS over HTTPS
    /// </summary>
    [MPKey(21), MP2Key(21), JsonPropertyOrder(21)]
    public bool UseDoh2 { get; set; } = IProxySettings.DefaultUseDoh2;

    /// <summary>
    /// 自定义 DNS over HTTPS 地址
    /// </summary>
    [MPKey(22), MP2Key(22), JsonPropertyOrder(22)]
    public string? CustomDohAddres { get; set; } = IProxySettings.DefaultCustomDohAddres;

    /// <summary>
    /// 加速页面 Tab 选项卡选中下标
    /// </summary>
    [MPKey(23), MP2Key(23), JsonPropertyOrder(23)]
    public int AcceleratorTabsSelectedIndex { get; set; } = IProxySettings.DefaultAcceleratorTabsSelectedIndex;

}

public static partial class ProxySettings
{
    /// <summary>
    /// 启用脚本自动检查更新
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> IsAutoCheckScriptUpdate { get; }
        = new(DefaultIsAutoCheckScriptUpdate);

    /// <summary>
    /// 启用代理脚本
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> IsEnableScript { get; }
        = new(DefaultIsEnableScript);

    /// <summary>
    /// 代理服务启用状态
    /// </summary>
    public static SettingsProperty<IReadOnlyCollection<string>, ProxySettings_> SupportProxyServicesStatus { get; }
        = new(DefaultSupportProxyServicesStatus);

    /// <summary>
    /// 脚本启用状态
    /// </summary>
    public static SettingsProperty<IReadOnlyCollection<int>, ProxySettings_> ScriptsStatus { get; }
        = new(DefaultScriptsStatus);

    #region 代理设置

    /// <summary>
    /// 程序启动时自动启动代理
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> ProgramStartupRunProxy { get; }
        = new(DefaultProgramStartupRunProxy);

    /// <summary>
    /// 系统代理模式端口
    /// </summary>
    public static SettingsStructProperty<ushort, ProxySettings_> SystemProxyPortId { get; }
        = new(DefaultSystemProxyPortId);

    /// <summary>
    /// 系统代理模式IP
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> SystemProxyIp { get; }
        = new(DefaultSystemProxyIp);

    /// <summary>
    /// 开启加速后仅代理脚本而不加速
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> OnlyEnableProxyScript { get; }
        = new(DefaultOnlyEnableProxyScript);

    /// <summary>
    /// 代理时使用的解析主DNS
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> ProxyMasterDns { get; }
        = new(DefaultProxyMasterDns);

    /// <summary>
    /// 启用 Http 链接转发到 Https
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> EnableHttpProxyToHttps { get; }
        = new(DefaultEnableHttpProxyToHttps);

    #endregion

    #region 本地代理设置

    /// <summary>
    /// Socks5 Enable
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> Socks5ProxyEnable { get; }
        = new(DefaultSocks5ProxyEnable);

    /// <summary>
    /// Socks5 监听端口
    /// </summary>
    public static SettingsStructProperty<ushort, ProxySettings_> Socks5ProxyPortId { get; }
        = new(DefaultSocks5ProxyPortId);

    #endregion

    #region 二级代理设置

    /// <summary>
    /// TwoLevelAgent Enable
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> TwoLevelAgentEnable { get; }
        = new(DefaultTwoLevelAgentEnable);

    /// <summary>
    /// TwoLevelAgent ProxyType
    /// </summary>
    public static SettingsStructProperty<ExternalProxyType, ProxySettings_> TwoLevelAgentProxyType { get; }
        = new(DefaultTwoLevelAgentProxyType);

    /// <summary>
    /// 二级代理 IP
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> TwoLevelAgentIp { get; }
        = new(DefaultTwoLevelAgentIp);

    /// <summary>
    /// 二级代理 监听端口
    /// </summary>
    public static SettingsStructProperty<ushort, ProxySettings_> TwoLevelAgentPortId { get; }
        = new(DefaultTwoLevelAgentPortId);

    /// <summary>
    /// TwoLevelAgent UserName
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> TwoLevelAgentUserName { get; }
        = new(DefaultTwoLevelAgentUserName);

    /// <summary>
    /// TwoLevelAgent Password
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> TwoLevelAgentPassword { get; }
        = new(DefaultTwoLevelAgentPassword);

    #endregion

    #region 代理模式设置

    /// <summary>
    /// 当前代理模式
    /// </summary>
    public static SettingsStructProperty<ProxyMode, ProxySettings_> ProxyMode { get; }
        = new(DefaultProxyMode);

    #endregion

#if (WINDOWS || MACCATALYST || MACOS || LINUX) && !(IOS || ANDROID)

    /// <summary>
    /// 启用 GOG 插件代理
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> IsProxyGOG { get; }
        = new(DefaultIsProxyGOG);

    /// <summary>
    /// 是否只针对 Steam 内置浏览器启用脚本
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> IsOnlyWorkSteamBrowser { get; }
        = new(DefaultIsOnlyWorkSteamBrowser);

#endif

    /// <summary>
    /// 启用 DNS over HTTPS
    /// </summary>
    public static SettingsStructProperty<bool, ProxySettings_> UseDoh2 { get; }
        = new(DefaultUseDoh2);

    /// <summary>
    /// 自定义 DNS over HTTPS 地址
    /// </summary>
    public static SettingsProperty<string, ProxySettings_> CustomDohAddres { get; }
        = new(DefaultCustomDohAddres);

    /// <summary>
    /// 加速页面 Tab 选项卡选中下标
    /// </summary>
    public static SettingsStructProperty<int, ProxySettings_> AcceleratorTabsSelectedIndex { get; }
        = new(DefaultAcceleratorTabsSelectedIndex);

}
