Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.Xpo
Imports DevExpress.XtraReports.Extensions
Imports DevExpress.XtraReports.UI
' ...

Namespace AdvancedSupportForEnums
    Partial Public Class Form1
        Inherits Form
        Shared Sub New()
            ReportDesignExtension.RegisterExtension(New CustomReportExtension(), TeamParameterName)
        End Sub

        Private report As XtraReport
        Private Const TeamParameterName As String = "Team"

        Public Sub New()
            InitializeComponent()

            FillDataSource()
            Dim dataSource As New XPCollection(Of Person)()

            report = New XtraReport()
            report.DataSource = dataSource

            ReportDesignExtension.AssociateReportWithExtension(report, TeamParameterName)
        End Sub

        Private Sub FillDataSource()

            If New XPCollection(Of Person)().Count < 6 Then
                Dim team1 As New Team() With {.Name = "Team 1"}
                team1.Save()
                Dim team2 As New Team() With {.Name = "Team 2"}
                team2.Save()
                Dim team3 As New Team() With {.Name = "Team 3"}
                team3.Save()

                Dim TempPerson1 As Person = New Person()
                TempPerson1.FirstName = "Name 1, team1"
                TempPerson1.Team = team1
                TempPerson1.DateOfBirth = DateTime.Now.AddYears(-1)
                TempPerson1.Gender = PersonGender.Mr
                TempPerson1.Save()

                Dim TempPerson2 As Person = New Person()
                TempPerson2.FirstName = "Name 1, team2"
                TempPerson2.Team = team2
                TempPerson2.DateOfBirth = DateTime.Now
                TempPerson2.Gender = PersonGender.Mrs
                TempPerson2.Save()

                Dim TempPerson3 As Person = New Person()
                TempPerson3.FirstName = "Name 1, team3"
                TempPerson3.Team = team3
                TempPerson3.DateOfBirth = DateTime.Now
                TempPerson3.Gender = PersonGender.Mrs
                TempPerson3.Save()

                Dim TempPerson4 As Person = New Person()
                TempPerson4.FirstName = "Name 2, team1"
                TempPerson4.Team = team1
                TempPerson4.DateOfBirth = DateTime.Now.AddYears(-1)
                TempPerson4.Gender = PersonGender.Mr
                TempPerson4.Save()

                Dim TempPerson5 As Person = New Person()
                TempPerson5.FirstName = "Name 2, team2"
                TempPerson5.Team = team2
                TempPerson5.DateOfBirth = DateTime.Now
                TempPerson5.Gender = PersonGender.Mrs
                TempPerson5.Save()

                Dim TempPerson6 As Person = New Person()
                TempPerson6.FirstName = "Name 2, team3"
                TempPerson6.Team = team3
                TempPerson6.DateOfBirth = DateTime.Now
                TempPerson6.Gender = PersonGender.Mrs
                TempPerson6.Save()
            End If
        End Sub

        Private Sub btnDesigner_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btnDesigner.Click
            report.ShowDesignerDialog()
        End Sub

        Private Class CustomReportExtension
            Inherits ReportDesignExtension
            Private repositoryDataSource As New XPCollection(Of Team)()
            Public Sub New()
            End Sub

            Public Overrides Sub AddParameterTypes(ByVal dictionary As IDictionary(Of Type, String))
                dictionary.Add(GetType(PersonGender), "Person's Gender")
            End Sub

        End Class
    End Class
End Namespace
