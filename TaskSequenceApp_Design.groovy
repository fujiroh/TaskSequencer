@startuml

package View{
    class MainForm{
        - appCOntroller : AppController
        + CreateSorter() : ISort
    }

    ' 自作コントロール
    class UserControl{

    }

    class TaskControl{

    }

    class SubTaskLabel{

    }

    class TaskBoard{

    }

    ' 関係
    TaskControl ..|> UserControl
    SubTaskLabel ..|> UserControl
    TaskBoard ..|> UserControl
    SubTaskLabel --o TaskControl
    TaskControl --o MainForm
    TaskBoard --o MainForm
}

package Controller{
    ' Controller
    class AppController{
        - _taskList : IList<Task>
        - sorter : ISort
        + AddTask(string taskName) : void
        + Save() : void
        + Load() : void
    }
    MainForm o-- AppController
}

' タスクデータ
package TaskData{
    class Task{
        - _id : int
        - _status : TaskStatus
        - _priority : Priority    
        - _taskName : string
        - subTaskList : IList<SubTask>

        + Add(SubTask subtask) : void
        + Swap(SubTask subtask1,SubTask subtask2) : void
        + Delete(int id) : void
        + Clone() : Task
    }

    class SubTask{
        - _id : int
        - _taskName : string
        - _isCompleted : bool

        + IsCompleted {get; set;} : bool
        + Id {get; set;} : int
        + Clone() : SubTask
    }

    enum Priority{
        Low
        Medium
        High
    }

    enum TaskStatus{
        Do
        Doing
        Done
    }

    ' 関係
    Task "1" o-- "0..*" SubTask
    Task <|-- TaskStatus
    Task <|-- Priority

}

AppController "1" o-- "..*" Task

' その他
class UniqueIdFactory{
    {static} + Create() : int
}

Task --> UniqueIdFactory
SubTask --> UniqueIdFactory

interface IDisposable{

}

package Sorter{
    ' タスクのソート
    interface ISort{
        + Sort(IList tasks, bool isAscendingOrder) : void
    }

    class PrioritySorter{
        + PrioritySorter()
        + Sort(IList tasks, bool isAscendingOrder) : void
    }

    class TaskStatusSorter{
        + PrioritySorter()
        + Sort(IList tasks, bool isAscendingOrder) : void
    }

    ISort <|.. TaskStatusSorter
    ISort <|.. PrioritySorter
    ISort --o AppController
    IDisposable <|.. ISort
}

' シリアライズ
package Serialize{
    class JsonSerializer{
        + Load() : void
        + Write() : void 
    }

    class TaskJsonData{
        [DataMember]
        + TaskList : IList<Task>
    }

    class SubTaskJsonData{
        [DataMember]
        + SubTaskList : IList<SubTask>
    }

    AppController --> JsonSerializer
    TaskJsonData --> JsonSerializer
    SubTaskJsonData --> JsonSerializer
    Task --> TaskJsonData
    SubTask --> SubTaskJsonData
}

@enduml