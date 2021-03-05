# node_zlib_binding_err_internal_assertion

* compile & run consoleapp1

* init node project by `npm i` or `yarn`
* start node project by `npm run start` or `yarn start`

```
> ws_test@0.1.0 start
> node start

12345678
internal/assert.js:14
    throw new ERR_INTERNAL_ASSERTION(message);
    ^

Error [ERR_INTERNAL_ASSERTION]: zlib binding closed
This is caused by either a bug in Node.js or incorrect usage of Node.js internals.
Please open an issue with this stack trace at https://github.com/nodejs/node/issues

    at assert (internal/assert.js:14:11)
    at InflateRaw.ZlibBase.reset (zlib.js:318:5)
    at ...\ws_test\node\node_modules\ws\lib\permessage-deflate.js:383:23
    at errorBuffer (internal/streams/writable.js:486:5)
    at afterWrite (internal/streams/writable.js:470:5)
    at onwrite (internal/streams/writable.js:446:7)
    at InflateRaw.afterTransform (internal/streams/transform.js:103:3)
    at Zlib.processCallback (zlib.js:546:10) {
  code: 'ERR_INTERNAL_ASSERTION'
}
npm ERR! code 1
npm ERR! path ...\ws_test\node
npm ERR! command failed
npm ERR! command C:\WINDOWS\system32\cmd.exe /d /s /c node start

npm ERR! A complete log of this run can be found in:
npm ERR!     ...\AppData\Local\npm-cache\_logs\2021-03-05T16_21_19_288Z-debug.log
```
