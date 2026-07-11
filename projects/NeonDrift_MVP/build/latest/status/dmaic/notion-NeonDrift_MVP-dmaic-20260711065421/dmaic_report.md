# OPDCA + DMAIC Pipeline Review

## Summary

- status: failed
- project_name: NeonDrift_MVP
- chain_id: raw:NeonDrift_MVP:20260711061938
- run_id: notion-NeonDrift_MVP-dmaic-20260711065421
- source_pipeline: qa
- checks_total: 12
- checks_failed: 1
- knowledge_base: workspace/public_document/knowledge_base/game_quality/OPDCA_DMAIC_CYCLE.md

## OPDCA

- Observe: Collect completed pipeline state, generated files, Notion row metadata, QA evidence, and validation reports.
- Plan: Route to DMAIC root-cause analysis because one or more OPDCA checks failed.
- Do: Run OPDCA evidence checks and DMAIC quality analysis for source pipeline 'qa'.
- Check: 1 failed checks detected.
- Act: Create remediation row targeting development and require concrete runtime/product evidence before passing.

## DMAIC - Define

- Problem statement: pipeline output must be detailed, playable, visually rich, evidence-backed, and traceable from raw idea to QA.
- Customer requirement: Notion must show whether planning/spec/development/build/QA evidence is sufficient before advancing.

## DMAIC - Measure

- PASS raw_idea_defined: passed
- PASS define_contract_present: passed
- PASS planning_depth_present: passed
- PASS spec_review_actionable: passed
- PASS development_unity_project_present: passed
- PASS development_runtime_probe_present: passed
- PASS build_evidence_present: passed
- PASS qa_evidence_present: passed
- PASS qa_hard_gates_present: passed
- PASS qa_runtime_evidence_artifacts_present: passed
- PASS pipeline_chain_continuity: passed
- FAIL qa_failure_signals_resolved: 12 QA failure signals require remediation

## DMAIC - Analyze

- qa_failure_signals_resolved: 12 QA failure signals require remediation

## Root Causes

- visual_richness_gap -> development: Runtime visuals are still too placeholder/dark/static for release quality.
- retry_runtime_motion_gap -> development: Retry leaves failure state but does not provide verified live gameplay motion after retry.
- human_product_experience_gate_failed -> development: QA common-sense/product-experience gates failed; implementation and evidence must be improved before release.

## DMAIC - Improve

- remediation_target: development
- Return to QA/Development loop: require simulator video, screenshots, product experience, human visual judgement, and every core gameplay function evidence.
- Create remediation Notion row targeting development; do not stop at reporting.

## Remediation Request

DMAIC remediation target: development

Root causes:
- visual_richness_gap: Runtime visuals are still too placeholder/dark/static for release quality.
- retry_runtime_motion_gap: Retry leaves failure state but does not provide verified live gameplay motion after retry.
- human_product_experience_gate_failed: QA common-sense/product-experience gates failed; implementation and evidence must be improved before release.

Required correction:
- Do not mark the remediation passed unless generated runtime/product evidence directly resolves the listed root causes.
- Preserve the Chain ID and source DMAIC report for traceability.
- If returning to Development, fix implementation, visual readability, gameplay playability, runtime QA probe/evidence, and retry/menu/gameplay states before Build.
- If returning to QA, rerun simulator QA and produce screenshots, video/recording evidence, raw evidence JSON, and human product-experience checks.

Observed QA failure signals:
- | qa_retry_visual_recovery_gate | Visual | FAIL | retryProbePresent=False, screenState=None, isGameOver=None, gameOverPanelVisible=None, gameOverToRetry={'comparable': True, 'mean_abs_diff': 1.975, 'changed_ratio': 0.0085, 'sample_count': 1
- | qa_retry_live_motion_after_retry_gate | Gameplay | FAIL | retryProbePresent=False, retryLiveProbePresent=False, retryScreenState=None, retryLiveScreenState=None, retryGameplayTime=None, retryLiveGameplayTime=None, retryScore=None, retryLi
- | playthrough_retry_to_retry_live_changed | Playthrough | FAIL | {'comparable': True, 'mean_abs_diff': 0.05, 'changed_ratio': 0.0004, 'sample_count': 12000, 'changed': False} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644
- | qa_visual_richness_quality_gate | Visual | FAIL | gameplayVisualsVerified=True, gameplayInstructionReadableVerified=True, humanReadableGameplayContractVerified=True, videoExists=True, menuToGameplayChanged=True, gameplayToGameOverChanged=
- | qa_retry_restarts_gameplay_gate | Gameplay | FAIL | retryRestartsGameplayVerified=True, RetryRestartsGameplay=True, RawRetryRestartsMovingGameplay=False, gameOverToRetryChanged=True, retryVisualStateVisible=False. | /home/node/.openclaw/w
- | qa_retry_live_probe_leaves_failure_state | Gameplay | FAIL | screenState=None, isGameOver=None, gameOverPanelVisible=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_s
- | qa_human_visual_judgement_gate | Visual | FAIL | videoExists=True, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, retryLiveScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChange
- | qa_product_experience_gate | Gameplay | FAIL | menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=True, hasObjectiveText=True, hasAvoidInstructionText
- | qa_common_sense_veto_gate | UI/UX | FAIL | commonSenseVetoFailures=qa_retry_visual_recovery_gate=FAIL, qa_retry_live_motion_after_retry_gate=FAIL, qa_visual_richness_quality_gate=FAIL, qa_retry_restarts_gameplay_gate=FAIL, qa_human_visual
- - status: failed
- - qa_overall_status: failed
- "expected": "QA must fail whenever the product feels unreasonable to a human: confusing gameplay, inert motion, unclear objective, unclear controls, weak visual feedback, overlapping states, placeholder visuals, missing audio/feedback evide

## DMAIC - Control

- Keep this DMAIC row linked by Chain ID and source page.
- OPDCA Act decides whether to create remediation or close as control monitoring.
- Any future QA pass without product experience, human visual judgement, function playability, and recording evidence must remain failed.
- Any Development pass without runtime implementation evidence must be blocked before Build.

## QA Failure Signals

| qa_retry_visual_recovery_gate | Visual | FAIL | retryProbePresent=False, screenState=None, isGameOver=None, gameOverPanelVisible=None, gameOverToRetry={'comparable': True, 'mean_abs_diff': 1.975, 'changed_ratio': 0.0085, 'sample_count': 1
| qa_retry_live_motion_after_retry_gate | Gameplay | FAIL | retryProbePresent=False, retryLiveProbePresent=False, retryScreenState=None, retryLiveScreenState=None, retryGameplayTime=None, retryLiveGameplayTime=None, retryScore=None, retryLi
| playthrough_retry_to_retry_live_changed | Playthrough | FAIL | {'comparable': True, 'mean_abs_diff': 0.05, 'changed_ratio': 0.0004, 'sample_count': 12000, 'changed': False} | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644
| qa_visual_richness_quality_gate | Visual | FAIL | gameplayVisualsVerified=True, gameplayInstructionReadableVerified=True, humanReadableGameplayContractVerified=True, videoExists=True, menuToGameplayChanged=True, gameplayToGameOverChanged=
| qa_retry_restarts_gameplay_gate | Gameplay | FAIL | retryRestartsGameplayVerified=True, RetryRestartsGameplay=True, RawRetryRestartsMovingGameplay=False, gameOverToRetryChanged=True, retryVisualStateVisible=False. | /home/node/.openclaw/w
| qa_retry_live_probe_leaves_failure_state | Gameplay | FAIL | screenState=None, isGameOver=None, gameOverPanelVisible=None. | /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/qa/screenshots/ios_s
| qa_human_visual_judgement_gate | Visual | FAIL | videoExists=True, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, retryLiveScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChange
| qa_product_experience_gate | Gameplay | FAIL | menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=True, hasObjectiveText=True, hasAvoidInstructionText
| qa_common_sense_veto_gate | UI/UX | FAIL | commonSenseVetoFailures=qa_retry_visual_recovery_gate=FAIL, qa_retry_live_motion_after_retry_gate=FAIL, qa_visual_richness_quality_gate=FAIL, qa_retry_restarts_gameplay_gate=FAIL, qa_human_visual
- status: failed
- qa_overall_status: failed
"expected": "QA must fail whenever the product feels unreasonable to a human: confusing gameplay, inert motion, unclear objective, unclear controls, weak visual feedback, overlapping states, placeholder visuals, missing audio/feedback evide
