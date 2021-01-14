var openFilePicker = function (apiKey, policy, signature) {
    const clientOptions = {
        security: {
            policy: policy,
            signature: signature
        }
    }

    const client = filestack.init(apiKey, clientOptions);
    client.picker().open();
}
