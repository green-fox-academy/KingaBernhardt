package com.kindergarten.demo.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
@NoArgsConstructor
@Setter
@Getter
public class Teacher {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String firstName;
  private String lastName;
  private String aboutMe;
  @OneToOne
  private Group group;

  public Teacher(String firstName, String lastName,String aboutMe, Group group) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.aboutMe = aboutMe;
    this.group = group;
  }
}
