Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Math

Public Class FrmMain

    Public pointScale As Point
    Dim tbWidthReslut As Integer
    Dim tbHeightReslut As Integer

    Dim TbWidthDesktop As Integer
    Dim TbHeightDesktop As Integer

    Dim TbWidthDesktopScale As Integer
    Dim TbHeightDesktopScale As Integer

    Dim TextSizeDektop As Integer

    Private Sub PicObject_MouseDown(sender As Object, e As MouseEventArgs) Handles PicObject.MouseDown
        If e.Button = MouseButtons.Left Then
            pointScale = e.Location
        End If
    End Sub

    Private Sub PicObject_MouseMove(sender As Object, e As MouseEventArgs) Handles PicObject.MouseMove
        If e.Button = MouseButtons.Left Then
            'image
            PicObject.Top = e.Y + PicObject.Top - pointScale.Y
            PicObject.Left = e.X + PicObject.Left - pointScale.X

            'lokasi scale
            TextLocX.Text = e.X + PicObject.Left - pointScale.X
            TextLocY.Text = e.Y + PicObject.Top - pointScale.Y
        End If

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Size Width 
        PicObject.Width = BarW.Value : BarWText.Text = BarW.Value & "%"
        'Size Height 
        PicObject.Height = BarH.Value : BarHText.Text = BarH.Value & "%"

        'lokasi scale
        TextLocX.Text = PicObject.Left - pointScale.X
        TextLocY.Text = PicObject.Top - pointScale.Y

    End Sub

    Private Sub BarW_Scroll(sender As Object, e As EventArgs) Handles BarW.Scroll
        PicObject.Width = BarW.Value : BarWText.Text = BarW.Value & " %"

    End Sub

    Private Sub BarH_Scroll(sender As Object, e As EventArgs) Handles BarH.Scroll
        PicObject.Height = BarH.Value : BarHText.Text = BarH.Value & "%"
    End Sub

    Private Sub CmdShow_Click(sender As Object, e As EventArgs) Handles CmdShow.Click

        If CmdShow.Text = "Tampilkan" Then

            With FrmView


                'Form
                .Width = (PicObject.Width * tbWidthReslut) 'Koma diganti dengan (Titik) kalau pake koma Bug
                .Height = (PicObject.Height * tbHeightReslut) 'Koma diganti dengan (Titik) kalau pake koma Bug
                'form
                .Left = (PicObject.Left * tbWidthReslut) 'Koma diganti dengan (Titik) kalau pake koma Bug
                .Top = (PicObject.Top * tbHeightReslut) 'Koma diganti dengan (Titik) kalau pake koma Bug

                .Show()

                CmdShow.Text = "Sembunyikan"
            End With
        Else
            FrmView.Close()
            FrmView.Dispose()

            CmdShow.Text = "Tampilkan"

        End If


    End Sub

    Private Sub FrmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        'Ukuran Desktop
        TbWidthDesktop = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Width
        TbHeightDesktop = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Height

        'Ukuran Desktop Scale
        TbWidthDesktopScale = PanelDesktop.Size.Width
        TbHeightDesktopScale = PanelDesktop.Size.Height

        'Hasil Pembagian
        tbWidthReslut = TbWidthDesktop / TbWidthDesktopScale
        tbHeightReslut = Val(TbHeightDesktop) / Val(TbHeightDesktopScale)

        'Hasil Pembagian
        TextSizeDektop = Round(Val(tbWidthReslut) * Val(TextSizeDektop), 2)

    End Sub
End Class
