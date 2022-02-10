Public Class frmMain

    Shared Sub Main()
        Application.Run(New frmMain)
    End Sub

    ''' <summary>
    ''' フォームロード
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUrl.Text = "http://localhost:8080/api/resource/123?param=abc"
    End Sub

    ''' <summary>
    ''' GETボタン押下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        '' URLの取得
        Dim url As String = txtUrl.Text

        '' レスポンスのクリア
        Me.ClearResponse()

        '' GET送信
        Try
            Using client As New System.Net.Http.HttpClient()

                Using response As System.Net.Http.HttpResponseMessage = client.GetAsync(url).Result
                    Dim responseBody As String = response.Content.ReadAsStringAsync().Result
                    txtResp.Text = responseBody
                End Using
            End Using

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            txtResp.Text = ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' POSTボタン押下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        '' URLの取得
        Dim url As String = txtUrl.Text

        '' レスポンスのクリア
        Me.ClearResponse()

        '' POST送信
        Try
            Using client As New Net.Http.HttpClient()

                Dim jsonText As String = "{""name"":""福山太郎"",""note"":""岡山県人？"",""age"":75,""registerDate"":""1916-07-01T02:03:04""}"
                Dim requestContent As New Net.Http.StringContent(jsonText, System.Text.Encoding.UTF8, "application/json")

                Using response As Net.Http.HttpResponseMessage = client.PostAsync(url, requestContent).Result
                    Dim responseBody As String = response.Content.ReadAsStringAsync().Result
                    txtResp.Text = responseBody
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            txtResp.Text = ex.Message
        End Try

    End Sub

    ''' <summary>
    ''' PUTボタン押下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPut_Click(sender As Object, e As EventArgs) Handles btnPut.Click
        '' URLの取得
        Dim url As String = txtUrl.Text

        '' レスポンスのクリア
        Me.ClearResponse()

        '' PUT送信
        Try
            Using client As New Net.Http.HttpClient()

                Dim jsonText As String = "{""name"":""岩国次郎"",""note"":""広島県人？"",""age"":26,""registerDate"":""1940-04-01T00:00:00""}"
                Dim requestContent As New Net.Http.StringContent(jsonText, System.Text.Encoding.UTF8, "application/json")

                Using response As Net.Http.HttpResponseMessage = client.PutAsync(url, requestContent).Result
                    Dim responseBody As String = response.Content.ReadAsStringAsync().Result
                    txtResp.Text = responseBody
                End Using
            End Using

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            txtResp.Text = ex.Message

        End Try
    End Sub

    ''' <summary>
    ''' DELETEボタン押下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '' URLの取得
        Dim url As String = txtUrl.Text

        '' レスポンスのクリア
        Me.ClearResponse()

        '' DELETE送信
        Try
            Using client As New System.Net.Http.HttpClient()
                Using response As System.Net.Http.HttpResponseMessage = client.DeleteAsync(url).Result
                    Dim responseBody As String = response.Content.ReadAsStringAsync().Result
                    txtResp.Text = responseBody
                End Using
            End Using

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            txtResp.Text = ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' クリアボタン押下
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ClearResponse()

    End Sub

    ''' <summary>
    ''' レスポンスのクリア
    ''' </summary>
    Private Sub ClearResponse()
        txtResp.Text = ""
    End Sub

End Class
