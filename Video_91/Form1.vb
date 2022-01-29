Imports Video_91.Person
Public Class Form1

    Private myDefaultPerson As New Person(150, 500, 20, "Default Person")
    Private myPeople As New ArrayList
    Private selectedPerson As Person
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableButtons()
    End Sub

    Private Sub disableButtons()
        btnEat.Enabled = False
        btnExercise.Enabled = False
        btnWork.Enabled = False
        btnIncreaseIncome.Enabled = False
    End Sub

    Private Sub enableButtons()
        btnEat.Enabled = True
        btnExercise.Enabled = True
        btnWork.Enabled = True
        btnIncreaseIncome.Enabled = True
    End Sub

    Private Sub updateWeight(ByRef person As Person)
        lblWeight.Text = "Current Weight: " & person.getWeight().ToString()
    End Sub
    Private Sub updateMoney(ByRef person As Person)
        lblMoney.Text = "Current Money: " & person.getMoney().ToString()
    End Sub
    Private Sub updateIncome(ByRef person As Person)
        lblIncome.Text = "Current Income: " & person.getIncome().ToString()
    End Sub

    Private Sub updateAll(ByRef person As Person)
        updateWeight(person)
        updateMoney(person)
        updateIncome(person)
    End Sub

    Private Sub btnEat_Click(sender As Object, e As EventArgs) Handles btnEat.Click
        selectedPerson.eat(5)
        updateWeight(selectedPerson)
    End Sub

    Private Sub btnWork_Click(sender As Object, e As EventArgs) Handles btnWork.Click
        selectedPerson.work(8)
        updateMoney(selectedPerson)
    End Sub

    Private Sub btnExercise_Click(sender As Object, e As EventArgs) Handles btnExercise.Click
        selectedPerson.exercise(3)
        updateWeight(selectedPerson)
    End Sub

    Private Sub btnIncreaseIncome_Click(sender As Object, e As EventArgs) Handles btnIncreaseIncome.Click
        selectedPerson.increaseIncome(2.5)
        updateIncome(selectedPerson)
    End Sub

    Private Sub btnNewPerson_Click(sender As Object, e As EventArgs) Handles btnNewPerson.Click
        Dim name As String = InputBox("Please input a name for your person", "Name", "JohnDoe")
        addPerson(name)
    End Sub

    Private Sub addPerson(ByVal pname As String)
        Dim myNewPerson As New Person(150, 999, 500, pname)
        myNewPerson.name = pname
        myPeople.Add(myNewPerson)
        listPeople.Items.Add(myNewPerson.name)
    End Sub

    Private Sub listPeople_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listPeople.SelectedIndexChanged
        If listPeople.SelectedIndex <> -1 Then
            enableButtons()
            selectedPerson = myPeople(listPeople.SelectedIndex)
            updateAll(selectedPerson)
        Else
            MessageBox.Show("Please select a person", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            disableButtons()
        End If
    End Sub
End Class
