Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nums(9) As Integer
        Dim sum As Double = 0
        TextBox1.Text = ""
        Randomize()
        For i = 0 To UBound(nums)
            If i > 0 Then
                TextBox1.Text &= ", "
            End If
            nums(i) = Int(100 * Rnd())
            TextBox1.Text &= nums(i)
            sum += nums(i)
        Next

        Dim count As Integer = nums.Length
        Label2.Text = $"ผลรวม : {sum}  "
        Label2.Text &= $"ค่าเฉลี่ย : {sum / count}"

        Dim max, min As Integer
        max = 0
        min = nums(0)
        For i = 0 To UBound(nums)
            If nums(i) > max Then
                max = nums(i)
            End If
            If nums(i) < min Then
                min = nums(i)
            End If
        Next
        Label3.Text = $"ค่าสูงสุด : {max} "
        Label3.Text &= $"ค่าต่ำสุด : {min}"
    End Sub
End Class
