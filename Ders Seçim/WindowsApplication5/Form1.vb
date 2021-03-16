
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label2.Text = "Kalan Süreniz:"
        Label4.Text = ""
        Dim t As Integer = 120 'sayacın başlayacağı saniyeyi gösteren değişken
        Label3.Text = t


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label3.Text = CInt(Label3.Text) - 1 'ders seçimi için kalan süreyi belirleyen timer
        If Label3.Text = 0 Then
            Timer1.Enabled = False
            Dim cevap As Integer
            cevap = MsgBox("Ders Seçimi İçin Süreniz Doldu.Ek Süre İster Misiniz?", vbYesNo + 32, "ÖBS")
            If cevap = vbYes Then

                Dim t As Integer = 120
                Label3.Text = t
                Timer1.Enabled = True
            Else
                MsgBox("Ders Seçiminiz Hayırlı Olsun",, "ÖBS")
                Me.Close()



            End If


        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ListBox1.Items.Clear()
        ListBox1.Items.Add("ders4_1")
        ListBox1.Items.Add("ders4_2")
        ListBox1.Items.Add("ders4_3")
        ListBox1.Items.Add("ders4_4")
        Label4.Text = "Ders Seçimi Onaylanmamıştır!"
        Label3.Text = 120
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ListBox1.Items.Clear()
        ListBox1.Items.Add("ders2_1")
        ListBox1.Items.Add("ders2_2")
        ListBox1.Items.Add("ders2_3")
        ListBox1.Items.Add("ders2_4")
        Label4.Text = "Ders Seçimi Onaylanmamıştır!"
        Label3.Text = 120
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ListBox1.Items.Clear()
        ListBox1.Items.Add("ders1_1")
        ListBox1.Items.Add("ders1_2")
        ListBox1.Items.Add("ders1_3")
        ListBox1.Items.Add("ders1_4")
        Label4.Text = "Ders Seçimi Onaylanmamıştır!"
        Label3.Text = 120

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ListBox1.Items.Clear()
        ListBox1.Items.Add("ders3_1")
        ListBox1.Items.Add("ders3_2")
        ListBox1.Items.Add("ders3_3")
        ListBox1.Items.Add("ders3_4")
        Label4.Text = "Ders Seçimi Onaylanmamıştır!"
        Label3.Text = 120
    End Sub

    Private Sub RadioButton5_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        ListBox1.Items.Clear()
        ListBox1.Items.Add("seçmeli_1")
        ListBox1.Items.Add("seçmeli_2")
        ListBox1.Items.Add("seçmeli_3")
        ListBox1.Items.Add("seçmeli_4")
        Label4.Text = "Ders Seçimi Onaylanmamıştır!"
        Label3.Text = 120
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sorgu As String
        Dim sorgu2 As String
        Dim sorgu3 As String
        Dim sorgu4 As String
        sorgu = "seçmeli_1"
        sorgu2 = "seçmeli_2"
        sorgu3 = "seçmeli_3"
        sorgu4 = "seçmeli_4"
        Label3.Text = 120

        If ListBox1.SelectedIndex < 0 Then 'ders seçilmeden ekle butonuna tıklandığında olacak hata

            Label4.Text = "Lütfen Ders Seçiniz!"
        Else
            If RadioButton5.Checked = True Then
                If ListBox2.Items.Contains(sorgu) Then

                    Label4.Text = "Seçmeli Dersten En Fala 1 Tane Seçebilirsin!"
                ElseIf ListBox2.Items.Contains(sorgu2) Then

                    Label4.Text = "Seçmeli Dersten En Fala 1 Tane Seçebilirsin!"
                ElseIf ListBox2.Items.Contains(sorgu3) Then

                    Label4.Text = "Seçmeli Dersten En Fala 1 Tane Seçebilirsin!"
                ElseIf ListBox2.Items.Contains(sorgu4) Then

                    Label4.Text = "Seçmeli Dersten En Fala 1 Tane Seçebilirsin!"

                Else
                    ListBox2.Items.Add(ListBox1.SelectedItem)
                    Dim x As String
                    x = ListBox1.SelectedItem
                    Dim y As String
                    y = " dersi eklenmiştir!"
                    Label4.Text = x + y
                    Timer2.Enabled = True
                End If

            Else
                If ListBox2.Items.Contains(ListBox1.Text) Then ' aynı ders bir daha seçilmek 
                    Label4.Text = "Seçilmiş Bir Ders!"          'istenirse gösterilecek hata

                ElseIf ListBox2.Items.Count >= 6 Then '6 dersten fazla seçim yapamazsınız uyarısı

                    Label4.Text = "En Fazla 6 Ders Seçimi Yapılabilir!"

                Else

                    Dim x As String
                    x = ListBox1.SelectedItem
                    Dim y As String
                    y = " dersi eklenmiştir!"
                    ListBox2.Items.Add(ListBox1.SelectedItem)
                    Label4.Text = x + y
                    Timer2.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seçili As String
        seçili = ListBox2.SelectedIndex
        If ListBox2.SelectedIndex < 0 Then
            Label4.Text = "Lütfen Ders Seçiniz"
        Else
            Label4.Text = ListBox2.Items(seçili) + " dersi çıkartılmıştır!"
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            Timer2.Enabled = True
        End If
        Label3.Text = 120


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim sonuç As String
        sonuç = CStr(Button3.Text)
        If sonuç = "ONAYI KALDIR" Then 'onayı kaldırdıktan sonra yapılacak işlemler
            Label3.Text = 120
            Timer1.Enabled = True
            Timer2.Enabled = True
            GroupBox1.Enabled = True
            ListBox1.Enabled = True
            ListBox2.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Label4.Text = "Ders Seçimi Onaylanmamıştır"
            Button3.Text = "ONAYLA"
        Else
            Timer1.Enabled = False 'onayla butonuna basıldığında yapılacak işlemler
            Timer2.Enabled = False
            GroupBox1.Enabled = False
            ListBox1.Enabled = False
            ListBox2.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Label4.Text = "Ders Seçimi Onaylanmıştır"
            Button3.Text = "ONAYI KALDIR"

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 3000
        Dim başlangıç As Integer = 0 '
        başlangıç = başlangıç + 1

        If başlangıç = 1 Then
            Label4.Text = "Ders Seçimi Onaylanmamıştır!"
            Timer2.Enabled = False
        End If

        'ders seçimi bilgisi verildikten sonra aktif olan timer.
        '3 saniye sonra ders seçiminin onaylanmadığını bildirecek.
        'onayla butonuna basılma durumunda enable=false olacak

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label3.Text = 120
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Label3.Text = 120
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Label3.Text = 120
    End Sub


    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class
