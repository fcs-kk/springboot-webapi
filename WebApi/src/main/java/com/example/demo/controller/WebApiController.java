package com.example.demo.controller;

import org.springframework.core.env.Environment;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api")
public class WebApiController {
 
  @RequestMapping("hello")
  private String hello() {
      return "SpringBoot!";
  }

  /** POST処理 */
  @RequestMapping(value="/resource/{id}", method=RequestMethod.POST)
  private String create(@PathVariable String id, @RequestBody String data) {
      return "Called POST.\r\n[id]=" + id + "\r\n[data]=" + data;
  }
  /** GET処理 */
  @RequestMapping(value="/resource/{id}", method=RequestMethod.GET)
  private String read(@PathVariable String id) {
      return "Called GET.\r\n[id]=" + id;
  }
  /** DELETE処理 */
  @RequestMapping(value="/resource/{id}", method=RequestMethod.DELETE)
  private String delete(@PathVariable String id) {
      return "Called DELETE.\r\n[id]=" + id;
  }

  /** PUT処理 */
  @RequestMapping(value="/resource/{id}", method=RequestMethod.PUT)
  private String update(@PathVariable String id, @RequestBody String data) {
      return "Called PUT.\r\n[id]=" + id;
  }
}

