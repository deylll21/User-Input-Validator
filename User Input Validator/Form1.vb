Public Class Form1

    ' Custom exception class for negative age
    Public Class NegativeAgeException
        Inherits ApplicationException
        Public Sub New(message As String)
            MyBase.New(message)
        End Sub
    End Class

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim ageInput As String = txtAge.Text
        Dim age As Integer

        Try
            age = Convert.ToInt32(ageInput)

            If age < 0 Then
                Throw New NegativeAgeException("Age cannot be negative.")
            End If

            lblResult.Text = "Your age is: " & age.ToString()

        Catch ex As FormatException
            lblResult.Text = "Please enter a valid numeric value for age."

        Catch ex As NegativeAgeException
            lblResult.Text = ex.Message

        Catch ex As Exception
            lblResult.Text = "An unexpected error occurred: " & ex.Message
        End Try
    End Sub
End Class