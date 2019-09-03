package com.softserve.edu;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.testng.Assert;
import org.testng.annotations.Test;

public class AppTest {

	public static final Logger logger = LoggerFactory.getLogger(AppTest.class);

	@Test
	public void testApp() {
		logger.trace("message text");
		logger.debug("message text");
		logger.info("message text");
		logger.warn("message text");
		logger.error("message text");
		Assert.assertTrue(true);
	}

}
