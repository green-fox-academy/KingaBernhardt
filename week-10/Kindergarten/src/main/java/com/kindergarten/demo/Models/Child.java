package com.kindergarten.demo.Models;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
public class Child {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String name;
  private Integer age;
  private String sign;

  @ManyToMany
  private List<Teacher> teachers = new ArrayList<>();

  public Child() {
  }

  public Child(String name, Integer age, String sign) {
    this.name = name;
    this.age = age;
    this.sign = sign;
  }

  public Long getId() {
    return id;
  }

  public void setId(Long id) {
    this.id = id;
  }

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Integer getAge() {
    return age;
  }

  public void setAge(Integer age) {
    this.age = age;
  }

  public String getSign() {
    return sign;
  }

  public void setSign(String sign) {
    this.sign = sign;
  }

  public Parent getParent() {
    return parent;
  }

  public void setParent(Parent parent) {
    this.parent = parent;
  }

  public List<Teacher> getTeachers() {
    return teachers;
  }

  public void setTeachers(List<Teacher> teachers) {
    this.teachers = teachers;
  }
}
