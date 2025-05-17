Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
''' <summary>
''' 窗体深色模式函数集合模块
''' </summary>
Module Darkmode
#Region "声明部分"
    ''' <summary>
    ''' DWM枚举
    ''' </summary>
    Private Enum DwmWindowAttribute
        NCRenderingEnabled = 1
        NCRenderingPolicy
        TransitionsForceDisabled
        AllowNCPaint
        CaptionButtonBounds
        NonClientRtlLayout
        ForceIconicRepresentation
        Flip3DPolicy
        ExtendedFrameBounds
        HasIconicBitmap
        DisallowPeek
        ExcludedFromPeek
        Cloak
        Cloaked
        FreezeRepresentation
        PassiveUpdateMode
        UseHostBackdropBrush
        UseImmersiveDarkMode = 20
        WindowCornerPreference = 33
        BorderColor
        CaptionColor
        TextColor
        VisibleFrameBorderThickness
        SystemBackdropType
        Last
    End Enum 'DWM枚举
    ''' <summary>
    ''' 为窗口设置外观相关属性
    ''' </summary>
    ''' <param name="hwnd">要为其设置属性值的窗口的句柄</param>
    ''' <param name="attr">描述要设置的值的标志，指定为 DWMWINDOWATTRIBUTE 枚举的值。</param>
    ''' <param name="attrValue">指向包含要设置的属性值的对象的指针。</param>
    ''' <param name="attrSize">通过 pvAttribute 参数设置的属性值的大小（以字节为单位）。</param>
    Private Declare Function DwmSetWindowAttribute Lib "DwmApi.dll" (
    ByVal hwnd As IntPtr,
    ByVal attr As DwmWindowAttribute,
    ByRef attrValue As Integer,
    ByVal attrSize As Integer
    ) As Long
    <DllImport("uxtheme.dll", EntryPoint:="#135", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Private Function SetPreferredAppMode(ByVal PreferredAppMode As PreferredAppMode) As Long
    End Function
    ''' <summary>
    ''' 刷新窗体自带的菜单项主题
    ''' </summary>
    <DllImport("uxtheme.dll", EntryPoint:="#136", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Function FlushMenuThemes() As Long
    End Function
    Private Enum PreferredAppMode
        _default
        AllowDark
        ForceDark
        ForceLight
        Max
    End Enum
#End Region
#Region "提供给外部的过程"
    ''' <summary>
    ''' 表明系统主题发生更改时的 Windows 消息
    ''' </summary>
    Public Const WM_DWMCOLORIZATIONCOLORCHANGED = &H320
    ''' <summary>
    ''' 根据当前系统主题，自动设定深色/浅色模式
    ''' </summary>
    ''' <param name="Form">要被修改主题的窗体</param>
    Public Sub AutoTheme(Form As Form)
        SetPreferredAppMode(PreferredAppMode.AllowDark)
        If IsDark() Then '如果是深色模式
            Dark(Form)
        Else
            Light(Form)
        End If
        FlushMenuThemes()
    End Sub
    ''' <summary>
    ''' 设定指定Form为浅色模式
    ''' </summary>
    ''' <param name="Form">要被修改主题的窗体</param>
    Public Sub Light(Form As Form)
        Form.BackColor = Color.FromArgb(240, 240, 240)
        For Each Ctls In Form.Controls
            Ctls.ForeColor = Color.FromArgb(0, 0, 0)
            Ctls.BackColor = Color.FromArgb(225, 225, 225)
        Next
        SetPreferredAppMode(PreferredAppMode.ForceLight)
        DwmSetWindowAttribute(Form.Handle, DwmWindowAttribute.UseImmersiveDarkMode, False, Marshal.SizeOf(Of Integer))
        FlushMenuThemes()
    End Sub
    ''' <summary>
    ''' 设定指定Form为深色模式
    ''' </summary>
    ''' <param name="Form">要被修改主题的窗体</param>
    Public Sub Dark(Form As Form)
        Form.BackColor = Color.FromArgb(32, 33, 36)
        For Each Ctls In Form.Controls
            Ctls.ForeColor = Color.FromArgb(218, 220, 224)
            Ctls.BackColor = Color.FromArgb(32, 33, 36)
        Next
        SetPreferredAppMode(PreferredAppMode.ForceDark)
        DwmSetWindowAttribute(Form.Handle, DwmWindowAttribute.UseImmersiveDarkMode, True, Marshal.SizeOf(Of Integer))
        FlushMenuThemes()
    End Sub
    ''' <summary>
    ''' 判断当前系统主题是否为深色模式
    ''' </summary>
    ''' <returns>若为深色模式则返回True,否则返回False</returns>
    Public Function IsDark() As Boolean
        Dim dKey = Microsoft.Win32.Registry.CurrentUser.
            OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", True).
            GetValue("AppsUseLightTheme", "0") '判断是否为深色主题
        Return If(dKey = 0, True, False)
    End Function
    ''' <summary>
    ''' 获得当前系统主题颜色
    ''' </summary>
    ''' <returns>当前主题色</returns>
    Public Function getColor() As Color
        Dim colorKey = Hex(Microsoft.Win32.Registry.CurrentUser.
            OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\History\Colors", True).
            GetValue("ColorHistory0", "0"))
        Return Color.FromArgb(
            Dec(colorKey.Substring(6, 2)),
            Dec(colorKey.Substring(4, 2)),
            Dec(colorKey.Substring(2, 2)))
    End Function
    ''' <summary>
    ''' 十六进制转十进制
    ''' </summary>
    ''' <param name="Hex">十六进制字符串(如7C)</param>
    ''' <returns>对应的十进制数</returns>
    Private Function Dec(Hex As String) As Integer
        Return Val("&H" & Hex & "&")
    End Function
#End Region
End Module
