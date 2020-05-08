Imports System.IO
Imports System.Windows.Forms



Public Class FMain



    Public Structure udtStudent

        Dim strFullName As String
        Dim strTestScore() As String
        Dim strAverage As String

    End Structure

    Dim f_audtStudents() As udtStudent


    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click

        Try

            If IsValidData() = True Then

                Dim decAverage1 As Decimal
                Dim decAverage2 As Decimal
                Dim decAverage3 As Decimal

                'Calculate Average
                decAverage1 = CalcAverage(txtTest1a, txtTest1b, txtTest1c)
                decAverage2 = CalcAverage(txtTest2a, txtTest2b, txtTest2c)
                decAverage3 = CalcAverage(txtTest3a, txtTest3b, txtTest3c)


                'Print it in the textboxes
                txtAverage1.Text = decAverage1.ToString
                txtAverage2.Text = decAverage2.ToString
                txtAverage3.Text = decAverage3.ToString


            End If


        Catch ex As Exception

            MessageBox.Show("Error calculating average", _
                            "Something went wrong", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Exclamation)

        End Try


    End Sub


    Private Function IsValidData() As Boolean

        Dim blnResult As Boolean = True

        'Valid name?
        If txtName1.Text <> "" Then

            'yes?
            If txtTest1a.Text = "" Or txtTest1b.Text = "" Or txtTest1c.Text = "" Then

                'Tests Empty? yes
                MessageBox.Show(" Test Score for First Student must not empty")
                blnResult = False

            ElseIf IsNumeric(txtTest1a.Text) = False Then

                'Numeric?
                MessageBox.Show("Test 1 must be numeric")
                txtTest1a.Focus()
                blnResult = False

            ElseIf IsNumeric(txtTest1b.Text) = False Then

                'Numeric?
                MessageBox.Show("Test 2 must be numeric")
                txtTest1b.Focus()
                blnResult = False

            ElseIf IsNumeric(txtTest1c.Text) = False Then

                'Numeric?
                MessageBox.Show("Test 3 must be numeric")
                txtTest1c.Focus()
                blnResult = False

            End If

        ElseIf txtName1.Text = "" Then

            'Name empty? Yes
            MessageBox.Show("Student 1 cannot be empty", _
                            "Please fill the textbox")
            txtName1.Focus()
            blnResult = False

        End If

        If txtName2.Text <> "" Then

            If txtTest2a.Text = "" Or txtTest2b.Text = "" Or txtTest2c.Text = "" Then

                MessageBox.Show(" Test Score for Second Student must not empty")
                blnResult = False

            ElseIf IsNumeric(txtTest2a.Text) = False Then

                MessageBox.Show("Test 1 must be numeric")
                txtTest2a.Focus()
                blnResult = False

            ElseIf IsNumeric(txtTest2b.Text) = False Then

                MessageBox.Show("Test 2 must be numeric")
                txtTest2b.Focus()
                blnResult = False

            ElseIf IsNumeric(txtTest2c.Text) = False Then

                MessageBox.Show("Test 3 must be numeric")
                txtTest2c.Focus()
                blnResult = False

            End If


        ElseIf txtName2.Text = "" Then

            MessageBox.Show("Student 2 cannot be empty", _
                            "Please fill the textbox")
            txtName2.Focus()
            blnResult = False

        End If

        If txtName3.Text <> "" Then

            If txtTest3a.Text = "" Or txtTest3b.Text = "" Or txtTest3c.Text = "" Then

                MessageBox.Show(" Test Score for Third Student must not empty")
                blnResult = False

            ElseIf IsNumeric(txtTest3a.Text) = False Then

                MessageBox.Show("Test 1 must be numeric")
                txtTest3a.Focus()
                blnResult = False

            ElseIf IsNumeric(txtTest3b.Text) = False Then

                MessageBox.Show("Test 2 must be numeric")
                txtTest3b.Focus()
                blnResult = False

            ElseIf IsNumeric(txtTest3c.Text) = False Then

                MessageBox.Show("Test 3 must be numeric")
                txtTest3c.Focus()
                blnResult = False

            End If

        ElseIf txtName3.Text = "" Then

            MessageBox.Show("Student 3 cannot be empty", _
                            "Please fill the textbox")
            txtName3.Focus()
            blnResult = False

        End If

        Return blnResult

    End Function



    Private Function CalcAverage(ByVal txtScore1 As TextBox, ByVal txtScore2 As TextBox, ByVal txtScore3 As TextBox) As Decimal

        Dim decValue As Decimal

        Dim decscore1 As Decimal
        Dim decScore2 As Decimal
        Dim decScore3 As Decimal

        decscore1 = Convert.ToDecimal(txtScore1.Text)
        decScore2 = Convert.ToDecimal(txtScore2.Text)
        decScore3 = Convert.ToDecimal(txtScore3.Text)

        decValue = decscore1 + decScore2 + decScore3

        decValue = decValue / 3

        Return decValue

    End Function







    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName1.Text = ""
        txtName2.Text = ""
        txtName3.Text = ""

        txtTest1a.Text = ""
        txtTest1b.Text = ""
        txtTest1c.Text = ""

        txtTest2a.Text = ""
        txtTest2b.Text = ""
        txtTest2c.Text = ""

        txtTest3a.Text = ""
        txtTest3b.Text = ""
        txtTest3c.Text = ""

        txtAverage1.Text = ""
        txtAverage2.Text = ""
        txtAverage3.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtAverage1.Enabled = False
        txtAverage2.Enabled = False
        txtAverage3.Enabled = False


    End Sub

    Private Sub msCalculateAverage_Click(sender As Object, e As EventArgs) Handles msCalculateAverage.Click

        Try

            If IsValidData() = True Then

                Dim decAverage1 As Decimal
                Dim decAverage2 As Decimal
                Dim decAverage3 As Decimal

                'Calculate Average
                decAverage1 = CalcAverage(txtTest1a, txtTest1b, txtTest1c)
                decAverage2 = CalcAverage(txtTest2a, txtTest2b, txtTest2c)
                decAverage3 = CalcAverage(txtTest3a, txtTest3b, txtTest3c)


                'Print it in the textboxes
                txtAverage1.Text = decAverage1.ToString
                txtAverage2.Text = decAverage2.ToString
                txtAverage3.Text = decAverage3.ToString


            End If


        Catch ex As Exception

            MessageBox.Show("Error calculating average", _
                            "Something went wrong", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Exclamation)

        End Try


    End Sub


    Private Sub msSave_Click(sender As Object, e As EventArgs) Handles msSave.Click

        SaveStudentInformation()


    End Sub

    Private Sub SaveStudentInformation()


        ' Dim ofdStudentFile As New OpenFileDialog
        ' Dim strInputFile As StreamReader
        '  Dim 

        Try

            ' ofdStudentFile = System.IO.File.AppendText(strInputFile)

            'obtain Data



        Catch ex As Exception

        End Try




    End Sub


    Private Sub msReload_Click(sender As Object, e As EventArgs) Handles msReload.Click

        LoadStudentFromFile()


    End Sub



    Private Sub LoadStudentFromFile()



        Dim ofdStudentsFile As New OpenFileDialog
        Dim strInputFile As StreamReader
        Dim strStudent As String
        Dim intIndex As Integer

        'Set Open file parameters
        ofdStudentsFile.CheckPathExists = True
        ofdStudentsFile.CheckFileExists = True
        ofdStudentsFile.Filter = "Text Files (*.txt)| *.txt|All Files (*.*)|*.*"

        'Get the name from the user
        ofdStudentsFile.ShowDialog()

        If ofdStudentsFile.FileName <> "" Then

            'Yes, so open the file
            strInputFile = New StreamReader(ofdStudentsFile.FileName)

            'Loop until end of file (Peek= -1)
            While strInputFile.Peek > -1

                'Read a line
                strStudent = strInputFile.ReadLine

                'Add it to array
                AddStudentToStructure(strStudent, intIndex)

                'Next contact
                intIndex += 1

            End While

        End If

        LoadTextBoxesWithArray()

     

    End Sub


    Private Sub AddStudentToStructure(strRecord As String, intRecordIndex As Integer)



        Dim astrStudentFields() As String

        'Split it


        If Not String.IsNullOrWhiteSpace(strRecord) Then

            astrStudentFields = Split(strRecord, ",")

            f_audtStudents(intRecordIndex).strFullName = astrStudentFields(0)

            f_audtStudents(intRecordIndex).strTestScore(0) = astrStudentFields(1)

            f_audtStudents(intRecordIndex).strTestScore(1) = astrStudentFields(2)

            f_audtStudents(intRecordIndex).strTestScore(2) = astrStudentFields(3)

            f_audtStudents(intRecordIndex).strAverage = astrStudentFields(4)


        End If

    End Sub



    Private Sub LoadTextBoxesWithArray()



        txtName1.Text = f_audtStudents(0).strFullName
        txtTest1a.Text = f_audtStudents(0).strTestScore(0).ToString
        txtTest1b.Text = f_audtStudents(0).strTestScore(1).ToString
        txtTest1c.Text = f_audtStudents(0).strTestScore(2).ToString
        txtAverage1.Text = f_audtStudents(0).strAverage.ToString

        txtName2.Text = f_audtStudents(1).strFullName
        txtTest2a.Text = f_audtStudents(1).strTestScore(0).ToString
        txtTest2b.Text = f_audtStudents(1).strTestScore(1).ToString
        txtTest2c.Text = f_audtStudents(1).strTestScore(2).ToString
        txtAverage2.Text = f_audtStudents(1).strAverage.ToString

        txtName3.Text = f_audtStudents(2).strFullName
        txtTest3a.Text = f_audtStudents(2).strTestScore(0).ToString
        txtTest3b.Text = f_audtStudents(2).strTestScore(1).ToString
        txtTest3c.Text = f_audtStudents(2).strTestScore(2).ToString
        txtAverage3.Text = f_audtStudents(2).strAverage.ToString



    End Sub



End Class
