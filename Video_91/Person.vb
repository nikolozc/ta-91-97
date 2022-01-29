Public Class Person
    Private weight As Double = 8
    Private money As Double = 100.0
    Private income As Double = 7.5
    Public name As String = Nothing

    Sub New(ByVal w As Double, ByVal m As Double, ByVal i As Double, ByVal n As String)
        weight = w
        money = m
        income = i
        name = n
    End Sub

    Public Sub eat(ByVal pounds As Double)
        weight += pounds
    End Sub
    Public Sub exercise(ByVal time As Double)
        weight -= time
    End Sub
    Public Sub work(ByVal hours As Double)
        money += income * hours
    End Sub
    Public Sub increaseIncome(ByVal amount As Double)
        income += amount
    End Sub


    Public Function getWeight() As Double
        Return weight
    End Function
    Public Function getMoney() As Double
        Return money
    End Function
    Public Function getIncome() As Double
        Return income
    End Function
End Class
