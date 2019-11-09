export default {
    newTask: state => state.newTask,
    tasks: state => state.tasks.filter((task) => { return !task.completedTask }),
    completedTask: state => state.tasks.filter((task) => { return task.completedTask })
}