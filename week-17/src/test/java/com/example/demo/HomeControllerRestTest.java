package com.example.demo;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mockito;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.WebMvcTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.mock.web.MockHttpServletResponse;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.MvcResult;
import org.springframework.test.web.servlet.RequestBuilder;
import org.springframework.test.web.servlet.request.MockMvcRequestBuilders;
import org.springframework.web.bind.annotation.RequestBody;
import sun.reflect.annotation.ExceptionProxy;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertThat;

@RunWith(SpringRunner.class)
@WebMvcTest(value = HomeController.class, secure = false)
public class HomeControllerRestTest {
  @Autowired
  private MockMvc mockMvc;
  
  @MockBean
  private HomeService mockedSpyService;
  
  @Test
  public void  testIndex() throws Exception {
    String body = "Kinga";
    String URI = "/";
  
    RequestBuilder requestBuilder = MockMvcRequestBuilders
        .post(URI)
        .accept(MediaType.TEXT_PLAIN).content(body)
        .contentType(MediaType.TEXT_PLAIN);
  
    Mockito.when(mockedSpyService.nameCheck(Mockito.any(String.class))).thenReturn("ok");
  
    MvcResult result = mockMvc.perform(requestBuilder).andReturn();
    MockHttpServletResponse response = result.getResponse();
    
    String outputString = response.getContentAsString();
    assertThat(outputString).isEqualTo("ok");
    assertEquals(HttpStatus.OK.value(), response.getStatus());
  }
}
