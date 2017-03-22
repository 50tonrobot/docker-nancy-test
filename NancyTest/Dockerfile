FROM mono:4.2.1.102
RUN mkdir /app
COPY bin/Release /app
EXPOSE 8888
CMD ["mono", "/app/NancyTest.exe", "-d"]
