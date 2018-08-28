package com.kindergarten.demo.Services;

import com.kindergarten.demo.Models.Teacher;
import com.kindergarten.demo.Repositories.TeacherRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class TeacherServiceImp implements TeacherService {

  private TeacherRepository teacherRepository;

  @Autowired
  public TeacherServiceImp(TeacherRepository teacherRepository) {
    this.teacherRepository = teacherRepository;
  }

  @Override
  public Teacher getTeacherById(Long id) {
    return teacherRepository.findById(id).get();
  }

  @Override
  public void addTeacher(Teacher teacher) {
    teacherRepository.save(teacher);
  }

  @Override
  public void deleteTeacherById(Long id) {
    teacherRepository.deleteById(id);
  }

  @Override
  public Iterable<Teacher> getAllTeacher() {
    return teacherRepository.findAll();
  }
}
