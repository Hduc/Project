export default {
  getTask(state, task) {
    state.newTask = task;
  },
  addTask(state) {
    state.tasks.push({
      body: state.newTask,
      completedTask: false
    });
  },
  editTask(state, task) {
    var tasks = state.tasks;
    tasks.splice(tasks.indexOf(task), 1);
    state.task = task.body;
    state.completedTask = task.completedTask;
  },
  removeTask(state, task) {
    var tasks = state.tasks;
    tasks.splice(tasks.indexOf(task), 1);
  },
  completedTask(state, task) {
    var tasks = state.tasks;
    tasks.splice(tasks.indexOf(task), 1);
    tasks.push({
      body: task.body,
      completedTask: true
    });
  },
  clearTask(state) {
    state.newTask = "";
  },
  setNotifications(state, noti) {
    state.notification.type = noti.type;
    state.notification.text = noti.text;
  }
};
