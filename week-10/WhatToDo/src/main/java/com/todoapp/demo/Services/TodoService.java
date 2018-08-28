package com.todoapp.demo.Services;

import com.todoapp.demo.Models.Todo;

import java.util.List;

public interface TodoService {
  List<Todo> getListOfTodos();

  List<Todo> getByTitle(String title);

  Todo AddTodo(Todo todo);

  void deleteById(Long id);

  Todo findById(long id);
}
