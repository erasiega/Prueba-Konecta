Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim apiKey As String = "041a28a35fd8e10d1206efd75fd75848" ' Reemplaza con tu clave de API de OpenWeatherMap
        Dim city As String = ComboBoxCities.SelectedItem.ToString()
        Dim units As String = If(RadioButtonCelsius.Checked, "metric", "imperial")
        Dim apiUrl As String = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=es"

        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString(apiUrl)
            Dim weatherData As WeatherResponse = JsonConvert.DeserializeObject(Of WeatherResponse)(response)

            LabelTemperature.Text = $"Temperatura: {weatherData.main.temp} °{If(units = "metric", "C", "F")}"
            LabelDescription.Text = $"Descripción: {weatherData.weather(0).description}"
            LabelFeelsLike.Text = $"Sensación térmica: {weatherData.main.feels_like} °{If(units = "metric", "C", "F")}"
        Catch ex As WebException
            Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()
            MessageBox.Show($"Error al conectar con la API: {response}")
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxCities_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCities.SelectedIndexChanged

    End Sub
End Class

Public Class WeatherResponse
    Public Property weather() As List(Of Weather)
    Public Property main() As Main
End Class

Public Class Weather
    Public Property description() As String
End Class

Public Class Main
    Public Property temp() As Double
    Public Property feels_like() As Double
End Class

