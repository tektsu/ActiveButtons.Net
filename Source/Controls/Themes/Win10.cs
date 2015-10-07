/*=============================================================================
 Win10 Theme

 This is a modified version od the Standard theme.
 This theme is incomplete, with the values likely correct only for Sizable windows. 
 *=============================================================================
 */
using System.Drawing;
using System.Windows.Forms;

namespace TheCodeKing.ActiveButtons.Controls.Themes
{
    internal class Win10 : ThemeBase
    {
        private Size maxFrameBorder = Size.Empty;
        private Size minFrameBorder = Size.Empty;

        public Win10(Form form)
            : base(form)
        {
        }

        public override Size FrameBorder
        {
            get
            {
                if (form.WindowState == FormWindowState.Maximized)
                {
                    if (maxFrameBorder == Size.Empty)
                    {
                        switch (form.FormBorderStyle)
                        {
                            case FormBorderStyle.FixedToolWindow:
                                maxFrameBorder = new Size(SystemInformation.FrameBorderSize.Width + 37, 10);
                                break;
                            case FormBorderStyle.SizableToolWindow:
                                maxFrameBorder = new Size(SystemInformation.FrameBorderSize.Width + 37, 10);
                                break;
                            case FormBorderStyle.Sizable:
                                maxFrameBorder = new Size(SystemInformation.FrameBorderSize.Width + 37, 10);
                                break;
                            default:
                                maxFrameBorder = new Size(SystemInformation.FrameBorderSize.Width + 37, 10);
                                break;
                        }
                    }
                    return maxFrameBorder;
                }
                else
                {
                    if (minFrameBorder == Size.Empty)
                    {
                        switch (form.FormBorderStyle)
                        {
                            case FormBorderStyle.FixedToolWindow:
                                minFrameBorder = new Size(SystemInformation.FrameBorderSize.Width + 35, 7);
                                break;
                            case FormBorderStyle.SizableToolWindow:
                                minFrameBorder = new Size(SystemInformation.FrameBorderSize.Width + 35, 7);
                                break;
                            case FormBorderStyle.Sizable:
                                minFrameBorder = new Size(SystemInformation.FrameBorderSize.Width + 35, 7);
                                break;
                            case FormBorderStyle.Fixed3D:
                                minFrameBorder = new Size(SystemInformation.Border3DSize.Width + 35, 7);
                                break;
                            case FormBorderStyle.FixedSingle:
                                minFrameBorder = new Size(SystemInformation.Border3DSize.Width + 35, 4);
                                break;
                            default:
                                minFrameBorder = new Size(SystemInformation.Border3DSize.Width + 35, 7);
                                break;
                        }
                    }
                    return minFrameBorder;
                }
            }
        }

    }
}